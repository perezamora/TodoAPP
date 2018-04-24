using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.DataAcces.Dao;

namespace Todo.Autofac.Configuration
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(RepositoryTodo<>))
               .As(typeof(IRepositoryTodo<>))
               .InstancePerRequest();

            builder.RegisterType<SqlServerDatabase>()
                .As<IDatabase>()
                .InstancePerRequest();

            base.Load(builder);
        }
    }
}
