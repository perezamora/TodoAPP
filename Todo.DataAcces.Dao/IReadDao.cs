using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.DataAcces.Dao
{
    public interface IReadDao<T>
    {
        T Select(T guid);
        T SelectById(T id);
        List<T> GetAll();
    }
}
