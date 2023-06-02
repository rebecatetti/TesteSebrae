using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using TesteSebrae.Domain.Entities;
using TesteSebrae.Domain.Repositories;
using TesteSebrae.Infra.Data;

namespace TesteSebrae.Infra.Repositories
{
    public class ContaRepository : IContaRepository
    {

        private readonly DataContext _context;
        public ContaRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ContaDTO>> Get()
        {
            return await _context.Conta.ToListAsync();

        }
        public async Task<bool> Criar(ContaDTO conta)
        {
            var criarconta = new ContaDTO()
            {
                Nome = conta.Nome,
                Descricao = conta.Descricao
            };

            await _context.Conta.AddAsync(criarconta);
            await _context.SaveChangesAsync();

			return true;
        }
        public async Task<bool> Excluir(ContaDTO conta)
        {
            _context.Conta.Remove(conta);
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<bool> Editar(ContaDTO conta)
        {
            _context.Conta.Update(conta);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
