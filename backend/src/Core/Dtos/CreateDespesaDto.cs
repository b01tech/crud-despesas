namespace Core.Dtos;

public record CreateDespesaDto(string Descricao, DateTime DataHora, decimal Valor, bool Pago = false);
