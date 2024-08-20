import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CalculadoraComponent } from './calculadora/calculadora.component';
import { RelatorioComponent } from './relatorio/relatorio.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [
    AppComponent,
      CalculadoraComponent,
      RelatorioComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      positionClass: 'toast-top-right', // ou 'toast-top-center', 'toast-top-full-width'
      timeOut: 5000, // duração do toast em ms
      progressBar: true, // barra de progresso no toast
      preventDuplicates: true, // evita duplicação de toasts
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
