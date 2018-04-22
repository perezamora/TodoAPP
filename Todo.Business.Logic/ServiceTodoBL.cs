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
    public class ServiceTodoBL : IServiceTodoBL
    {

        private readonly ILogger log = ConfigUtil.CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);
        private IRepositoryTodo<Tarea> tareaRepository;

        // Inyectamos el repository por el constructor
        public ServiceTodoBL(IRepositoryTodo<Tarea> repo)
        {
            // tareaRepository = new RepositoryTodo<Tarea>();
            tareaRepository = repo;
        }

        public Tarea Add(Tarea todo)
        {
            log.Debug(todo.ToString());
            try
            {
                todo.Guid = Guid.NewGuid().ToString();
                return tareaRepository.Insert(todo);
            }
            catch (TodoDaoException e)
            {
                log.Error(e.Message + e.StackTrace);
                throw new TodoBLException(Resource.logmessages.erroradd, e.InnerException);
            }
        }

        public int DeleteById(int id)
        {
            try
            {
                return tareaRepository.Delete(id);
            }
            catch (TodoDaoException e)
            {
                log.Error(e.Message + e.StackTrace);
                throw new TodoBLException(Resource.logmessages.errordelete, e.InnerException);
            }
        }

        public List<Tarea> GetAll()
        {
            try
            {
                return tareaRepository.GetAll();
            }
            catch (TodoDaoException e)
            {
                log.Error(e.Message + e.StackTrace);
                throw new TodoBLException(Resource.logmessages.errorgetall, e.InnerException);
            }
        }

        public Tarea GetById(int id)
        {
            try
            {
                return tareaRepository.SelectById(id);
            }
            catch (TodoDaoException e)
            {
                log.Error(e.Message + e.StackTrace);
                throw new TodoBLException(Resource.logmessages.errorgetbyid, e.InnerException);
            }
        }

        public Tarea Update(int id, Tarea todo)
        {
            try
            {
                return tareaRepository.Update(id, todo);
            }
            catch (TodoDaoException e)
            {
                log.Error(e.Message + e.StackTrace);
                throw new TodoBLException(Resource.logmessages.errorupdate, e.InnerException);
            }
        }
    }
}
