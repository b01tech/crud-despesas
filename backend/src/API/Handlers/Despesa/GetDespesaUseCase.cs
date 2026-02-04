using Core.Dtos;
using Core.Repositories;
using Core.UseCases.Despesa;

namespace API.Handlers.Despesa;

public class GetDespesaUseCase(IDespesaRepository repository) : IGetDespesaUseCase
{
    public async Task<DespesaDto?> ExecuteAsync(Guid id)
    {
        var despesa = await repository.GetByIdAsync(id);
        return despesa is null
            ? null
            : new DespesaDto(despesa.Descricao, despesa.DataHora, despesa.Pago, despesa.Valor);
    }
}
