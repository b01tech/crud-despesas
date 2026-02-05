import { Component, inject } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { DepesaCreateRequest } from '../models/depesa-create-request';
import { DepesaService } from '../services/depesa.service';

@Component({
  selector: 'app-criar-despesa',
  imports: [ReactiveFormsModule, RouterLink],
  templateUrl: './criar-despesa.html',
  styleUrl: './criar-despesa.css',
})
export class CriarDespesa {
  private readonly _fb = inject(FormBuilder);
  private readonly _despesaService = inject(DepesaService);
  private readonly _router = inject(Router);

  form = this._fb.group({
    descricao: ['', [Validators.required]],
    dataHora: ['', [Validators.required]],
    valor: [0, [Validators.required, Validators.min(0.01)]],
    pago: [false],
  });

  onSubmit() {
    if (this.form.invalid) {
      return;
    }
    const request: DepesaCreateRequest = this.form.value as DepesaCreateRequest;

    this._despesaService.postDespesa(request).subscribe({
      next: (response) => {
        this.form.reset();
        this._router.navigate(['/despesas']);
      },
      error: (error) => {
        console.error(error);
      },
    });
  }
}
