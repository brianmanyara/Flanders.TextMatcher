import { Component, OnInit } from '@angular/core';
import { AppService } from './app.service';
import { MatchResult } from './app.types';
import { isEmpty } from 'lodash';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  text: string;
  subText: string;
  matchResults: MatchResult[];
  isMatching = false;

  get enabled(): boolean {
    return !isEmpty(this.text) && !isEmpty(this.subText);
  }

  constructor(private service: AppService) {}

  match() {
    this.isMatching = true;
    this.service
      .match(this.text, this.subText)
      .toPromise()
      .then((matchResults) => {
        this.matchResults = matchResults;
        this.isMatching = false;
      });
  }

  clear() {
    this.text = undefined;
    this.subText = undefined;
    this.matchResults = undefined;
  }
}
