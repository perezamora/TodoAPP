using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Common.Logic.Model;

namespace Todo.Business.Logic
{
    public interface IServiceTodoBL
    {
        Tarea Add(Tarea todo);
        Tarea GetById(int id);
        Tarea Update(int id, Tarea todo);
        int DeleteById(int id);
        List<Tarea> GetAll();
    }
}
