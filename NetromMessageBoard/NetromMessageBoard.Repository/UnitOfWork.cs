using System;
using Autofac;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard.Repository
{
    public class UnitOfWork
    {
        private static readonly Lazy<UnitOfWork> Lazy = new Lazy<UnitOfWork>(() => new UnitOfWork());
        public static UnitOfWork Instance => Lazy.Value;
        
        public readonly IContainer Container;

        private UnitOfWork()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>();
            builder.RegisterType<DepartmentRepository>().As<IDepartmentRepository>();
            builder.RegisterType<TopicRepository>().As<ITopicRepository>();
            Container = builder.Build();
        }

        public T GetRepository<T>() where T : IBaseRepository
        {
            return Container.Resolve<T>();
        }
    }
}
