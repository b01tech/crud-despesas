import { Component, input } from '@angular/core';
import { DespesasApiResponse } from '../models/despesas-api-response';
import { DatePipe, CurrencyPipe } from '@angular/common';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-tabela',
  imports: [DatePipe, CurrencyPipe, RouterLink],
  templateUrl: './tabela.html',
  styleUrl: './tabela.css',
})
export class Tabela {
  listaDespesas = input<DespesasApiResponse[]>([]);
}
