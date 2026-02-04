import { Component, inject, OnInit } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { DespesaUpdateRequest } from '../models/despesa-update-request';
import { DepesaService } from '../services/depesa-service';

@Component({
  selector: 'app-editar-despesa',
  imports: [ReactiveFormsModule, RouterLink],
  templateUrl: './editar-despesa.html',
  styleUrl: './editar-despesa.css',
})
export class EditarDespesa implements OnInit {
  private readonly _fb = inject(FormBuilder);
  private readonly _despesaService = inject(DepesaService);
  private readonly _router = inject(Router);
  private readonly _route = inject(ActivatedRoute);

  despesaId: string | null = null;

  form = this._fb.group({
    descricao: ['', [Validators.required]],
    dataHora: ['', [Validators.required]],
    valor: [0 as any, [Validators.required, Validators.min(0.01)]],
    pago: [false],
  });

  ngOnInit() {
    this.despesaId = this._route.snapshot.paramMap.get('id');
    if (this.despesaId) {
      this.carregarDespesa(this.despesaId);
    }
  }

  carregarDespesa(id: string) {
    this._despesaService.getDespesaById(id).subscribe({
      next: (despesa) => {
        // Formatar data para datetime-local (YYYY-MM-DDTHH:mm)
        const dataFormatada = despesa.dataHora ? despesa.dataHora.substring(0, 16) : '';

        this.form.patchValue({
          descricao: despesa.descricao,
          dataHora: dataFormatada,
          valor: despesa.valor.toFixed(2),
          pago: despesa.pago,
        });
      },
      error: (error) => {
        console.error('Erro ao carregar despesa:', error);
        this._router.navigate(['/despesas']);
      },
    });
  }

  formatarValor() {
    const valorAtual = this.form.get('valor')?.value;
    if (valorAtual !== null && valorAtual !== undefined && valorAtual !== '') {
      const valorNumerico = parseFloat(valorAtual.toString());
      if (!isNaN(valorNumerico)) {
        this.form.patchValue({ valor: valorNumerico.toFixed(2) });
      }
    }
  }

  onSubmit() {
    if (this.form.invalid || !this.despesaId) {
      return;
    }

    const request: DespesaUpdateRequest = {
      id: this.despesaId,
      ...this.form.value,
      valor: parseFloat(this.form.value.valor!.toString()),
    } as DespesaUpdateRequest;

    this._despesaService.putDespesa(request).subscribe({
      next: () => {
        this.form.reset();
        this._router.navigate(['/despesas']);
      },
      error: (error) => {
        console.error('Erro ao atualizar despesa:', error);
      },
    });
  }
}
