namespace Core.UseCases.Despesa;

public interface IRemoveDespesaUseCase
{
    Task ExecuteAsync(Guid id);
}
