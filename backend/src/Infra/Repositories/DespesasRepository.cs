using Core.Entities;
using Core.Repositories;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories;

internal class DespesasRepository(AppDbContext dbContext) : IDespesaRepository
{
    public async Task<Despesa?> GetByIdAsync(Guid id)
    {
        return await dbContext.Despesas.FindAsync(id);
    }

    public async Task<IEnumerable<Despesa>> GetAllAsync()
    {
        return await dbContext.Despesas.AsNoTracking().Take(100).ToListAsync();
    }

    public async  Task AddAsync(Despesa despesa)
    {
        await dbContext.Despesas.AddAsync(despesa);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Despesa despesa)
    {
        dbContext.Despesas.Update(despesa);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Despesa despesa)
    {
        dbContext.Despesas.Remove(despesa);
        await dbContext.SaveChangesAsync();
    }
}
