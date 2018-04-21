using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.DataAcces.Dao
{
    public interface IReadDao<T>
    {
        T SelectById(T id);
        List<T> GetAll();
    }
}
