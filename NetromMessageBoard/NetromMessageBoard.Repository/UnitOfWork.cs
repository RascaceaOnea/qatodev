using System;
using Autofac;
using NetromMessageBoard.Repository.Interfaces;

namespace NetromMessageBoard.Repository
{
    public class UnitOfWork
    {
        private static Lazy<UnitOfWork> _lazy = new Lazy<UnitOfWork>(() => new UnitOfWork());
        public static UnitOfWork Instance => _lazy.Value;
        
        private IContainer Container;

        private UnitOfWork()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>();
            builder.RegisterType<DepartmentRepository>().As<IDepartmentRepository>();
            builder.RegisterType<TopicRepository>().As<ITopicRepository>();
            Container = builder.Build();
        }

        public T GetRepository<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
