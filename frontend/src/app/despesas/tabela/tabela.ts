import { CurrencyPipe, DatePipe } from '@angular/common';
import { Component, computed, inject, input, output } from '@angular/core';
import { RouterLink } from '@angular/router';
import { DespesasApiResponse } from '../models/despesas-api-response';
import { DepesaService } from '../services/depesa-service';

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
  totalDespesas = computed(() =>
    this.listaDespesas()
      .filter((d) => d.pago === false)
      .reduce((acc, cur) => acc + cur.valor, 0),
  );

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
