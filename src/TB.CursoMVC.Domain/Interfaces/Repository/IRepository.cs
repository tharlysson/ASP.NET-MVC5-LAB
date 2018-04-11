using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TB.CursoMVC.Domain.Models;

namespace TB.CursoMVC.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(Guid obj);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> ObterTodosPaginado(int s, int t);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }

    public interface IRepositoryChange<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Atualizar(TEntity obj);
        void Remover(Guid id);
    }
}