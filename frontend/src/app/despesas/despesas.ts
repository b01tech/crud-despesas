import { Component, inject, OnInit, signal } from '@angular/core';
import { Tabela } from './tabela/tabela';
import { DepesaService } from './services/depesa.service';
import { DespesasApiResponse } from './models/despesas-api-response';

@Component({
  selector: 'app-despesas',
  imports: [Tabela],
  templateUrl: './despesas.html',
  styleUrl: './despesas.css',
})
export class Despesas implements OnInit {
  private readonly _despesaService = inject(DepesaService);

  despesas = signal<DespesasApiResponse[]>([]);

  ngOnInit() {
    this.buscarDespesas();
  }

  buscarDespesas() {
    this._despesaService.getDespesas().subscribe({
      next: (response) => {
        console.log('Dados recebidos:', response);
        this.despesas.set(response);
      },
      error: (error) => {
        console.error('Erro ao buscar despesas:', error);
      },
    });
  }
}
