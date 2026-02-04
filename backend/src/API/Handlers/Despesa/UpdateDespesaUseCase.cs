using Core.Dtos;
using Core.Repositories;
using Core.UseCases.Despesa;

namespace API.Handlers.Despesa;

public class UpdateDespesaUseCase(IDespesaRepository repository) : IUpdateDespesaUseCase
{
    public async Task ExecuteAsync(UpdateDespesaDto request)
    {
        var despesa = await repository.GetByIdAsync(request.Id);
        if (despesa is null) return;
        despesa.Update(request.Descricao, request.DataHora, request.Valor, request.Pago);
        await repository.UpdateAsync(despesa);
    }
}
