import { Component, inject } from '@angular/core';
import { FormBuilder, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-criar-despesa',
  imports: [ReactiveFormsModule],
  templateUrl: './criar-despesa.html',
  styleUrl: './criar-despesa.css',
})
export class CriarDespesa {
  private readonly _fb = inject(FormBuilder);

  form = this._fb.group({
    descricao: ['', [Validators.required]],
    dataHora: ['', [Validators.required]],
    valor: [0, [Validators.required, Validators.min(0.01)]],
    pago: [false],
  });
}
