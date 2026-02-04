using Core.Dtos;

namespace Core.UseCases.Despesa;

public interface IUpdateDespesaUseCase
{
    Task ExecuteAsync(UpdateDespesaDto request);
}
