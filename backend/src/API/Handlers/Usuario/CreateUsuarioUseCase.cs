using Core.Dtos;
using Core.Repositories;
using Core.Services;
using Core.UseCases.Usuario;

namespace API.Handlers.Usuario;

internal class CreateUsuarioUseCase(IUsuarioRepository repository, IEncrypter encrypter) : ICreateUsuarioUseCase
{
    public async Task ExecuteAsync(CreateUsuarioDto request)
    {
        var hash = encrypter.Encrypt(request.Senha);
        var usuario = new Core.Entities.Usuario(
            request.Nome,
            request.Email,
            hash
        );
        await repository.AddAsync(usuario);
    }
}
