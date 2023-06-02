using TesteSebrae.Application.Models;
using TesteSebrae.Domain.Entities;

namespace TesteSebrae.Application.Interfaces
{
    public interface ICEPService
    {
        Task<CEPDTO> GetCEP();
    }
}
