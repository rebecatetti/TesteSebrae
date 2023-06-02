using TesteSebrae.Domain.Entities;

namespace TesteSebrae.Application.Interfaces
{
    public interface IContaService
    {
        Task<IEnumerable<ContaDTO>> Get();
		Task<bool> Criar(ContaDTO conta);
        Task<bool> Excluir(ContaDTO conta);
        Task<bool> Editar(ContaDTO conta);
    }
}
