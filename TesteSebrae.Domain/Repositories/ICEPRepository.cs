using TesteSebrae.Domain.Entities;

namespace TesteSebrae.Domain.Repositories
{
    public interface ICEPRepository
    {
        Task<CEPDTO> GetCEP();
    }
}
