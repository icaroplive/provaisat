using FluentValidation.Results;
using ISAT.Developer.Exam.Core.Entities;
using ISAT.Developer.Exam.Core.Interfaces;

namespace ISAT.Developer.Exam.Core.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : BaseEntity<TEntity>
    {
        #region properties

        readonly IRepository<TEntity> _repository;

        #endregion

        #region ctor

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        #endregion

        #region methods

        public virtual ValidationResult Insert(TEntity entity)
        {
            if (!entity.IsValid()) return entity.ValidationResult;

            _repository.Insert(entity);

            return null;
        }

        public virtual ValidationResult Delete(long id)
        {
            _repository.Delete(id);

            return null;
        }

        public virtual ValidationResult Update(TEntity entity)
        {
            if (!entity.IsValid()) return entity.ValidationResult;

            _repository.Update(entity);

            return null;
        }

        #endregion
    }
}