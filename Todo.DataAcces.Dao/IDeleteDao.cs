using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.DataAcces.Dao
{
    public interface IDeleteDao<T>
    {
        int Delete(T id);
    }
}
