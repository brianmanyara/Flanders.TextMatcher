export class MatchResult {
    position: number;
    value: string;

    constructor(data: Partial<MatchResult>) {
        Object.assign(this, data);
    }
}