import { Component } from '@angular/core';
import { Tabela } from './tabela/tabela';

@Component({
  selector: 'app-despesas',
  imports: [Tabela],
  templateUrl: './despesas.html',
  styleUrl: './despesas.css',
})
export class Despesas {}
