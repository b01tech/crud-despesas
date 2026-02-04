using Core.Dtos;

namespace Core.UseCases.Usuario;

public interface ILoginUsuarioUseCase
{
    Task<TokenResponseDto?> ExecuteAsync(LoginUsuarioDto request);
}
