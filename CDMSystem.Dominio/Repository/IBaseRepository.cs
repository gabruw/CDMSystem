using System;
using System.Collections.Generic;

namespace CDMSystem.Dominio.Contratos
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Incluid(TEntity entity);

        TEntity GetbyId(int id);

        IEnumerable<TEntity> GetAll();

        void Reflesh(TEntity entity);

        void Remove(TEntity entity);
    }
}