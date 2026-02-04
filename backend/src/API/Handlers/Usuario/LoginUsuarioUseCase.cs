using Core.Dtos;
using Core.Repositories;
using Core.UseCases.Usuario;

namespace API.Handlers.Usuario;

public class LoginUsuarioUseCase(IUsuarioRepository repository): ILoginUsuarioUseCase
{
    public async Task ExecuteAsync(LoginUsuarioDto request)
    {
        var usuario = await repository.GetByEmailAsync(request.Email);
        if (usuario is null)
        {
            throw new ApplicationException("Email ou senha inválidos");
        }
    }
}
