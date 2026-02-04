import { Component, signal } from '@angular/core';
import { Header } from './shared/header/header';
import { Despesas } from './despesas/despesas';

@Component({
  selector: 'app-root',
  imports: [Header, Despesas],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('CRUD Despesas');
}
