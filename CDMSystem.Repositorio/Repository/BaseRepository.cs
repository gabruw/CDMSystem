using System;
using System.Collections.Generic;

namespace CDMSystem.Dominio.Contratos
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public BaseRepository()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void Incluid(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Reflesh(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}