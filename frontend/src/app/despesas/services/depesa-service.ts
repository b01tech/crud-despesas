import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environment/environment';
import { HttpClient } from '@angular/common/http';
import { DespesasApiResponse } from '../models/despesas-api-response';
import { DepesaCreateRequest } from '../models/depesa-create-request';
import { DespesaUpdateRequest } from '../models/despesa-update-request';

@Injectable({
  providedIn: 'root',
})
export class DepesaService {
  private readonly _apiUrl = environment.apiUrl;
  private readonly _httpClient = inject(HttpClient);

  getDespesas() {
    return this._httpClient.get<DespesasApiResponse[]>(`${this._apiUrl}/despesas`);
  }
  getDespesaById(id: string) {
    return this._httpClient.get<DespesasApiResponse>(`${this._apiUrl}/despesas/${id}`);
  }
  postDespesa(request: DepesaCreateRequest) {
    return this._httpClient.post<DespesasApiResponse>(`${this._apiUrl}/despesas`, request);
  }
  deleteDespesa(id: string) {
    return this._httpClient.delete(`${this._apiUrl}/despesas/${id}`);
  }
  putDespesa(request: DespesaUpdateRequest) {
    return this._httpClient.put(`${this._apiUrl}/despesas`, request);
  }
}
