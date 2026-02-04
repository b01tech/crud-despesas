namespace Core.Entities;

public class Usuario
{
    public Guid Id { get; init; } = Guid.CreateVersion7();
    public string Nome { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string HashSenha { get; private set; } = string.Empty;

    protected Usuario() { }

    public Usuario(string nome, string email, string hashSenha)
    {
        Nome = nome;
        Email = email;
        HashSenha = hashSenha;
    }
}
