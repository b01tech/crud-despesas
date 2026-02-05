using Core.Dtos;
using Core.Repositories;
using Core.Services;
using Core.UseCases.Usuario;

namespace API.Handlers.Usuario;

public class LoginUsuarioUseCase(IUsuarioRepository repository, IEncrypter encrypter, ITokenService tokenService) : ILoginUsuarioUseCase
{
    public async Task<TokenResponseDto?> ExecuteAsync(LoginUsuarioDto request)
    {
        var usuario = await repository.GetByEmailAsync(request.Email);
        if (usuario is null)
            return null;
        var isPasswordValid = encrypter.Verify(request.Senha, usuario.HashSenha);
        if (!isPasswordValid)
            return null;
        var token = tokenService.GenerateToken(usuario.Nome);

        return new TokenResponseDto(usuario.Email, token);
    }
}
