using Core.Entities;
using Core.Repositories;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories;

public class UsuarioRepository(AppDbContext dbContext) : IUsuarioRepository
{
    public async Task AddAsync(Usuario usuario)
    {
        await dbContext.Usuarios.AddAsync(usuario);
        await dbContext.SaveChangesAsync();
    }

    public async Task<Usuario?> GetByEmailAsync(string email)
    {
        return await dbContext.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
    }
}
