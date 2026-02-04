using Core.Dtos;

namespace Core.UseCases.Despesa;

public interface IGetAllDespesaUseCase
{
    Task<List<DespesaDto>> ExecuteAsync();
}
