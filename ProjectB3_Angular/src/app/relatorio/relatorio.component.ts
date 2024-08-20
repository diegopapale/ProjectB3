import { Investment, InvestmentResult } from './../models/Investment.model';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CalculadoraService } from '../services/calculadora.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-relatorio',
  templateUrl: './relatorio.component.html',
  styleUrls: ['./relatorio.component.css']
})
export class RelatorioComponent implements OnInit {
  initialValue: number = 0;
  months: number= 0;
  netValue: number = 0;
  grossValue: number = 0;

  constructor(
    private router: Router,
    private calculadoraService: CalculadoraService,
    private toastr: ToastrService
  ) {
    const navigation = this.router.getCurrentNavigation();
    if (navigation?.extras.state) {
      const state = navigation.extras.state as { initialValue: number; months: number };
      this.initialValue = state.initialValue;
      this.months = state.months;
    }
  }

  ngOnInit(): void {
    const investment: Investment = {
      initialValue: this.initialValue,
      months: this.months,
    };

    this.calculadoraService
      .CalculateInvestment(investment)
      .subscribe((resultado: InvestmentResult) => {
        this.grossValue = resultado.GrossValue;
        this.netValue = resultado.NetValue;
      }, (error) => {
        
        this.toastr.error('Erro na chamada da API: ' + (error.error.ExceptionMessage || 'Erro desconhecido'), 'Erro', {
          toastClass: 'toast-error'
        });
      });
  }

  voltar() {
    this.router.navigate(['/calculadora']);
  }
}
