using Core.Entities;

namespace Core.Repositories;

public interface IUsuarioRepository
{
    Task AddAsync(Usuario usuario);
    Task<Usuario?> GetByEmailAsync(string email);
}
