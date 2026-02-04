using Core.Dtos;

namespace Core.UseCases.Despesa;

public interface ICreateDespesaUseCase
{
    Task ExecuteAsync(CreateDespesaDto request);
}
