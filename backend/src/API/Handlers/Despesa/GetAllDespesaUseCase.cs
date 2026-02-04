using Core.Dtos;
using Core.Repositories;
using Core.UseCases.Despesa;

namespace API.Handlers.Despesa;

public class GetAllDespesaUseCase(IDespesaRepository repository) : IGetAllDespesaUseCase
{
    public async Task<List<DespesaDto>> ExecuteAsync()
    {
        var despesas = await repository.GetAllAsync();
        return despesas.Select(x => new DespesaDto(x.Id, x.Descricao, x.DataHora, x.Pago, x.Valor)).ToList();
    }
}
