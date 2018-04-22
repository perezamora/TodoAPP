using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Todo.Autofac.Configuration;
using Todo.Business.Logic;
using Todo.DataAcces.Dao;

namespace Todo.Business.Facada.WebService.App_Start
{
    public class IocConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            // register 
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<ServiceTodoBL>().As<IServiceTodoBL>().InstancePerRequest();

            builder.RegisterGeneric(typeof(RepositoryTodo<>))
               .As(typeof(IRepositoryTodo<>))
               .InstancePerRequest();

            builder.RegisterType<SqlServerDatabase>().As<IDatabase>().InstancePerRequest();

            // construir container
            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}