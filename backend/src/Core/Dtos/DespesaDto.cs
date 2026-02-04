namespace Core.Dtos;

public record DespesaDto(Guid Id, string Descricao, DateTime DataHora, bool Pago, decimal Valor);
