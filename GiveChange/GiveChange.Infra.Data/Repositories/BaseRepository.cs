using System.Collections.Generic;
using System.Linq;
using GiveChange.Domain.Interfaces.Repositories;
using GiveChange.Infra.Data.Context;

namespace GiveChange.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Adicionando referência a classe de contexto
        /// </summary>
        protected readonly GiveChangeContext GiveChangeContext;

        public BaseRepository(GiveChangeContext giveChangeContext)
        {

            GiveChangeContext = giveChangeContext;

        }

        public void Adicionar(TEntity entity)
        {
            GiveChangeContext.Set<TEntity>().Add(entity);
            GiveChangeContext.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            GiveChangeContext.Set<TEntity>().Update(entity);
            GiveChangeContext.SaveChanges();

        }       

        public TEntity ObterPorId(int id)
        {
            return GiveChangeContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return GiveChangeContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            GiveChangeContext.Remove(entity);
            GiveChangeContext.SaveChanges();
        }

        public void Dispose()
        {
            GiveChangeContext.Dispose();
        }   
    }
}
