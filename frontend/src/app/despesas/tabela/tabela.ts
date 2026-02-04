import { Component, input } from '@angular/core';
import { DespesasApiResponse } from '../models/despesas-api-response';
import { DatePipe, CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-tabela',
  imports: [DatePipe, CurrencyPipe],
  templateUrl: './tabela.html',
  styleUrl: './tabela.css',
})
export class Tabela {
  listaDespesas = input<DespesasApiResponse[]>([]);
}
