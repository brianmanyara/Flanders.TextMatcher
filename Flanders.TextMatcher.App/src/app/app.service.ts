import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatchResult } from './app.types';
import { Observable } from 'rxjs';

@Injectable()
export class AppService {
  constructor(private http: HttpClient) {}

  match(text: string, subText: string): Observable<MatchResult[]>  {
    return this.http.get<MatchResult[]>(`api/match?text=${text}&subText=${subText}`);
  }
}
