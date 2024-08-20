import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-calculadora',
  templateUrl: './calculadora.component.html',
  styleUrls: ['./calculadora.component.css']
})
export class CalculadoraComponent implements OnInit {
  initialValue: number = 0;
  months: number= 0;

  constructor(private router: Router) { }

  ngOnInit() {
  }
  calcularInvestimento(form: any) {

    if (form.invalid) {
      return;
    }

    if (this.months < 1) {
      return;
    }

    if (this.initialValue <= 0) {
      return;
    }

    this.router.navigate(['/relatorio'], {
      state: {
        initialValue: this.initialValue,
        months: this.months
      }
    });
  }

}
