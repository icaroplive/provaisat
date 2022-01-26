using ISAT.Developer.Exam.Core.Entities.Models;
using ISAT.Developer.Exam.Infrastructure.Utilities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace ISAT.Developer.Exam.Infrastructure.ORM.Contexts
{
    public class EFContextDB : DbContext
    {
        #region properties

        #endregion

        #region ctor

        public EFContextDB(DbContextOptions<EFContextDB> options) : base(options)
        {

        }

        public DbSet<Usuario> usuario { get; set; }

        public EFContextDB() { }

        #endregion

        #region dbsets

        #endregion

        #region methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>(entity =>
           {
               entity.HasKey(user => user.Id);

               entity.Property(user => user.email);
               entity.Property(user => user.nome).HasMaxLength(255).IsRequired(); ;
               entity.Property(user => user.sobreNome).HasMaxLength(255).IsRequired(); ;
               entity.Property(user => user.idade);
               entity.Ignore(e => e.ValidationResult);
               entity.Ignore(e => e.CascadeMode);
           });

            base.OnModelCreating(modelBuilder);
        }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionStringUtility.GetConnectionString("SQLConnection"));
        }

        #endregion

    }
}