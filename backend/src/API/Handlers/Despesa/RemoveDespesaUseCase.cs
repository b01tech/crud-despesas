using Core.Repositories;
using Core.UseCases.Despesa;

namespace API.Handlers.Despesa;

public class RemoveDespesaUseCase(IDespesaRepository repository) : IRemoveDespesaUseCase
{
    public async Task ExecuteAsync(Guid id)
    {
        var despesa = await repository.GetByIdAsync(id);
        if (despesa is null) return;

        await repository.DeleteAsync(despesa);
    }
}
