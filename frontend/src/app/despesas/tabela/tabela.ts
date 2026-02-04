import { Component, inject, input, output } from '@angular/core';
import { DespesasApiResponse } from '../models/despesas-api-response';
import { DatePipe, CurrencyPipe } from '@angular/common';
import { RouterLink } from '@angular/router';
import { DepesaService } from '../services/depesa-service';
import { DespesaUpdateRequest } from '../models/despesa-update-request';

@Component({
  selector: 'app-tabela',
  imports: [DatePipe, CurrencyPipe, RouterLink],
  templateUrl: './tabela.html',
  styleUrl: './tabela.css',
})
export class Tabela {
  private readonly _despesaService = inject(DepesaService);
  listaDespesas = input<DespesasApiResponse[]>([]);
  despesaAtualizada = output<void>();

  deleteDespesa(id: string) {
    this._despesaService.deleteDespesa(id).subscribe({
      next: () => {
        console.log(`Despesa ${id} excluída com sucesso`);
        this.despesaAtualizada.emit();
      },
      error: (error) => {
        console.error('Erro ao excluir despesa:', error);
      },
    });
  }
}
