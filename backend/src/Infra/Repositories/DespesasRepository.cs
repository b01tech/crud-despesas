using Core.Entities;
using Core.Repositories;
using Infra.Data;

namespace Infra.Repositories;

internal class DespesasRepository(AppDbContext dbContext) : IDespesaRepository
{
    public Task<Despesa?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Despesa>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async  Task AddAsync(Despesa despesa)
    {
        await dbContext.Despesas.AddAsync(despesa);
        await dbContext.SaveChangesAsync();
    }

    public Task UpdateAsync(Despesa despesa)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Despesa despesa)
    {
        throw new NotImplementedException();
    }
}
