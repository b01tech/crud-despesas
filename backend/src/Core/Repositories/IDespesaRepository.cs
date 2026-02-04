using Core.Entities;

namespace Core.Repositories;

public interface IDespesaRepository
{
    Task<Despesa?> GetByIdAsync(Guid id);
    Task<IEnumerable<Despesa>> GetAllAsync();
    Task AddAsync(Despesa despesa);
    Task UpdateAsync(Despesa despesa);
    Task DeleteAsync(Despesa despesa);
}
