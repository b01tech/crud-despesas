namespace Core.Dtos;

public record UpdateDespesaDto(Guid Id, string Descricao, DateTime DataHora, decimal Valor, bool Pago = false);
