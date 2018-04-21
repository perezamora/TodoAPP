using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Todo.Business.Logic.Errors;
using Todo.Common.Logic.Logger;
using Todo.Common.Logic.Model;
using Todo.Common.Logic.Util;
using Todo.DataAcces.Dao;
using Todo.DataAcces.Dao.Errors;

namespace Todo.Business.Logic
{
    public class TodoBL : IServiceTodoBL
    {

        private readonly ILogger log = ConfigUtil.CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);
        private IRepositoryTodo<Tarea> tareaRepository;

        public Tarea Add(Tarea todo)
        {
            log.Debug(todo.ToString());
            tareaRepository = new RepositoryTodo<Tarea>();
            try
            {
                todo.Guid = Guid.NewGuid().ToString();
                return tareaRepository.Insert(todo);
            }
            catch (TodoDaoException e)
            {
                log.Error(e.Message + e.StackTrace);
                throw new TodoBLException("Error metodo Add ", e.InnerException);
            }
        }

        public int DeleteById(int id)
        {
            tareaRepository = new RepositoryTodo<Tarea>();
            try
            {
                return tareaRepository.Delete(id);
            }
            catch (TodoDaoException e)
            {
                log.Error(e.Message + e.StackTrace);
                throw new TodoBLException("Error metodo Add ", e.InnerException);
            }
        }

        public List<Tarea> GetAll()
        {
            tareaRepository = new RepositoryTodo<Tarea>();
            try
            {
                return tareaRepository.GetAll();
            }
            catch (TodoDaoException e)
            {
                log.Error(e.Message + e.StackTrace);
                throw new TodoBLException("Error metodo GetAll ", e.InnerException);
            }
        }

        public Tarea GetById(int id)
        {
            tareaRepository = new RepositoryTodo<Tarea>();
            try
            {
                return tareaRepository.SelectById(id);
            }
            catch (TodoDaoException e)
            {
                log.Error(e.Message + e.StackTrace);
                throw new TodoBLException("Error metodo GetById ", e.InnerException);
            }
        }

        public Tarea Update(int id, Tarea todo)
        {
            throw new NotImplementedException();
        }
    }
}
