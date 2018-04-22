using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Todo.Business.Logic;
using Todo.DataAcces.Dao;

namespace Todo.Autofac.Configuration
{
    public static class IocConfiguration
    {
        /*
        public static IContainer RegisterServices(ContainerBuilder builder)
        {
            return builder.RegisterType<ServiceTodoBL>().As<IServiceTodoBL>().InstancePerRequest();

        }*/

    }
}
