using System.Collections.Generic;
using TB.CursoMVC.Domain.Models;

namespace TB.CursoMVC.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>, IRepositoryChange<Cliente>
    {
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
        IEnumerable<Cliente> ObterAtivos();
    }
}