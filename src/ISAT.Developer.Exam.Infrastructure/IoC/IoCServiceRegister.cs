using ISAT.Developer.Exam.Core.Interfaces;
using ISAT.Developer.Exam.Core.Services;
using ISAT.Developer.Exam.Infrastructure.ORM.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ISAT.Developer.Exam.Infrastructure.IoC
{
    public class IoCServiceRegister
    {
        public static void Register(IServiceCollection services)
        {
            //Core
            services.AddTransient(typeof(IService<>), typeof(Service<>));

            //ORM
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        }
    }

    internal class Lazier<T> : Lazy<T> where T : class
    {
        public Lazier(IServiceProvider provider)
            : base(() => provider.GetRequiredService<T>())
        {
        }
    }
}
