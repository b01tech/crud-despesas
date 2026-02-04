using Core.Dtos;
using Core.Repositories;
using Core.UseCases.Despesa;

namespace API.Handlers.Despesa;

public class CreateDespesaUseCase(IDespesaRepository repository) : ICreateDespesaUseCase
{
    public async Task ExecuteAsync(CreateDespesaDto request)
    {
        var despesa = new Core.Entities.Despesa(descricao: request.Descricao, valor: request.Valor,
            dataHora: request.DataHora, pago: request.Pago);
        await repository.AddAsync(despesa);
    }
}
