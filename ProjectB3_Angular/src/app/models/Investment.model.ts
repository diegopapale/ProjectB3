export class Investment {
  initialValue: number;
  months: number;

  constructor(initialValue: number, months: number) {
    this.initialValue = initialValue;
    this.months = months;
  }
}

export interface InvestmentResult {
  NetValue: number;
  GrossValue: number;
}
