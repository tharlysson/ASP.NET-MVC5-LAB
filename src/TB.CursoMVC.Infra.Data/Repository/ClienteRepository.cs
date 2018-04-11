using System;
using System.Collections.Generic;
using System.Linq;
using TB.CursoMVC.Domain.Interfaces.Repository;
using TB.CursoMVC.Domain.Models;

namespace TB.CursoMVC.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente ObterPorCpf(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }

        public IEnumerable<Cliente> ObterAtivos()
        {
            return Buscar(c => c.Ativo);
        }

        public override void Remover(Guid id)
        {
            var cliente = ObterPorId(id);
            cliente.Excluir();

            Atualizar(cliente);
        }
    }
}