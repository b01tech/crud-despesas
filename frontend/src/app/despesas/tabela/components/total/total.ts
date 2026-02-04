import { CurrencyPipe } from '@angular/common';
import { Component, input } from '@angular/core';

@Component({
  selector: 'app-total',
  imports: [CurrencyPipe],
  templateUrl: './total.html',
  styleUrl: './total.css',
})
export class Total {
  totalDespesas = input<number>(0);
}
