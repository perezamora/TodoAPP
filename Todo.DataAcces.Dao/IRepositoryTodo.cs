using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.DataAcces.Dao
{
    public interface IRepositoryTodo<T> : ICreateDao<T>, IReadDao<T>, IUpdateDao<T>, IDeleteDao<T>
    {
    }
}
