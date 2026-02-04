using Core.Dtos;
using Core.Repositories;
using Core.UseCases.Usuario;

namespace API.Handlers.Usuario;

internal class CreateUsuarioUseCase(IUsuarioRepository repository) : ICreateUsuarioUseCase
{
    public async Task ExecuteAsync(CreateUsuarioDto request)
    {
        var usuario = new Core.Entities.Usuario(
            request.Nome,
            request.Email,
            request.Senha
        );
        await repository.AddAsync(usuario);
    }
}
