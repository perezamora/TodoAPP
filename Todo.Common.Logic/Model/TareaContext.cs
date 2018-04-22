using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Common.Logic.Model
{
    public class TareaContext : DbContext
    {

        public TareaContext() : base("TareaContext")
        {

            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Tarea> Tareas { get; set; }

    }
}
