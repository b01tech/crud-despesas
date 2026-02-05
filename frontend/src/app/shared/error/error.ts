import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-error',
  imports: [],
  templateUrl: './error.html',
  styleUrl: './error.css',
})
export class Error {
  errorMessage = signal<string>('Erro ao carregar dados');
}
