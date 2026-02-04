using Core.Dtos;

namespace Core.UseCases.Usuario;

public interface ILoginUsuarioUseCase
{
    Task ExecuteAsync(LoginUsuarioDto request);
}
