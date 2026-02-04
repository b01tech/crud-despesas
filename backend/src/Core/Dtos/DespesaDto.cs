namespace Core.Dtos;

public record DespesaDto(string Descricao, DateTime DataHora, bool Pago, decimal Valor);
