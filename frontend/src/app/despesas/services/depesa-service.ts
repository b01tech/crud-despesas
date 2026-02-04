import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environment/environment';
import { HttpClient } from '@angular/common/http';
import { DespesasApiResponse } from '../models/despesas-api-response';

@Injectable({
  providedIn: 'root',
})
export class DepesaService {
  private readonly _apiUrl = environment.apiUrl;
  private readonly _httpClient = inject(HttpClient);

  async getDespesas() {
    return this._httpClient.get<DespesasApiResponse[]>(`${this._apiUrl}/despesas`);
  }
}
