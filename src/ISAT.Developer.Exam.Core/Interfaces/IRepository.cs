using ISAT.Developer.Exam.Core.Entities;
using System.Collections.Generic;

namespace ISAT.Developer.Exam.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity<TEntity>
    {
        void Insert(TEntity entity);

        void Delete(long id);

        void Update(TEntity entity);

        TEntity GetById(long id);

        IEnumerable<TEntity> GetAll();
    }
}