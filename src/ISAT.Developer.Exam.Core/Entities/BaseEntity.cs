using FluentValidation;
using FluentValidation.Results;
using System;

namespace ISAT.Developer.Exam.Core.Entities
{
    public abstract class BaseEntity<TEntity> : AbstractValidator<TEntity> where TEntity : BaseEntity<TEntity>
    {
        #region properties

        public long Id { get; protected set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public string LastAction { get; private set; }

        public string LastLoginAction { get; private set; }

        public abstract bool IsValid();

        public ValidationResult ValidationResult { get; protected set; }

        #endregion

        #region ctor

        protected BaseEntity()
        {
            ValidationResult = new ValidationResult();
        }

        #endregion

        #region methods

        public void SetLastAction(string login = "Initial.Seed")
        {
            if (Id > 0)
            {
                LastAction = "Update";
                LastUpdatedDate = DateTime.Now;
            }
            else
            {
                LastAction = "Insert";
                CreatedDate = DateTime.Now;
            }

            LastLoginAction = login;
        }

        #endregion
    }
}