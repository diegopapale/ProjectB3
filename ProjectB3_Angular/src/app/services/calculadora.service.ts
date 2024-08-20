import { Investment, InvestmentResult } from './../models/Investment.model';
import { Injectable } from "@angular/core";
import{HttpClient} from "@angular/common/http"
import { Observable } from "rxjs";
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})

export class CalculadoraService {

  private apiUrl = environment.apiUrl;

  constructor(private http: HttpClient){}

  CalculateInvestment(investment: Investment): Observable<InvestmentResult> {
    return this.http.post<InvestmentResult>(`${this.apiUrl}/calculate`, investment);
  }

}
