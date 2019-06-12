using CDMSystem.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CDMSystem.Dominio.Contratos
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly CDMSystemContext CDMSystemContext;

        public BaseRepository(CDMSystemContext cdmSystemContext)
        {
            CDMSystemContext = cdmSystemContext;
        }

        public void Incluid(TEntity entity)
        {
            CDMSystemContext.Set<TEntity>().Add(entity);
            CDMSystemContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            CDMSystemContext.Set<TEntity>().Update(entity);
            CDMSystemContext.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            CDMSystemContext.Remove(entity);
            CDMSystemContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return CDMSystemContext.Set<TEntity>().ToList();
        }

        public TEntity GetbyId(int Id)
        {
            return CDMSystemContext.Set<TEntity>().Find(Id);
        }

        public void Dispose()
        {
            CDMSystemContext.Dispose();
        }
    }
}