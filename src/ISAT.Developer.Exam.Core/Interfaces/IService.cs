using FluentValidation.Results;
using ISAT.Developer.Exam.Core.Entities;

namespace ISAT.Developer.Exam.Core.Interfaces
{
    public interface IService<TEntity> where TEntity : BaseEntity<TEntity>
    {
        ValidationResult Insert(TEntity entity);

        ValidationResult Delete(long id);

        ValidationResult Update(TEntity entity);
    }
}