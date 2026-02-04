using Core.Dtos;

namespace Core.UseCases.Usuario;

public interface ICreateUsuarioUseCase
{
    Task ExecuteAsync(CreateUsuarioDto request);
}
