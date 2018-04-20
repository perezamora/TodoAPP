using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.DataAcces.Dao
{
    public class RepositoryTodo<T> : IRepositoryTodo<T>
    {
        public int Delete(T id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T insert(T item)
        {
            throw new NotImplementedException();
        }

        public T Select(T guid)
        {
            throw new NotImplementedException();
        }

        public T SelectById(T id)
        {
            throw new NotImplementedException();
        }

        public T Update(T id)
        {
            throw new NotImplementedException();
        }
    }
}
