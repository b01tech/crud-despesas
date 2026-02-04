export interface DespesaUpdateRequest {
  id: string;
  descricao: string;
  dataHora: string;
  valor: number;
  pago: boolean;
}
