using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Common.Logic.Model;

namespace Todo.DataAcces.Dao.Context
{
    public class TodoContext : DbContext
    {
        public DbSet<Tarea> Tareas { get; set; }

    }
}
