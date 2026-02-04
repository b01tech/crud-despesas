using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Despesa> Despesas { get; set; } = null!;
    public DbSet<Usuario> Usuarios { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Despesa>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Descricao).IsRequired();
            entity.Property(e => e.DataHora).IsRequired();
            entity.Property(e => e.Valor).IsRequired();
            entity.Property(e => e.Pago).IsRequired();
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nome).IsRequired();
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.HashSenha).IsRequired();
        });
    }
}
