using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.DataAcces.Dao
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(RepositoryTodo<>))
               .As(typeof(IRepositoryTodo<>))
               .InstancePerRequest();

            builder.RegisterType<SqlServerDatabase>().As<IDatabase>().InstancePerRequest();

            base.Load(builder);
        }
    }
}
