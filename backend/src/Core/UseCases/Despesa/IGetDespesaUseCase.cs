using Core.Dtos;

namespace Core.UseCases.Despesa;

public interface IGetDespesaUseCase
{
    Task<DespesaDto?> ExecuteAsync(Guid id);
}
