using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using Todo.Autofac.Configuration;
using Todo.Business.Logic;
using Todo.Business.Logic.Errors;
using Todo.Common.Logic.Logger;
using Todo.Common.Logic.Model;
using Todo.Common.Logic.Util;

namespace Todo.Business.Facada.WebService.Controllers
{
    public class TodoController : ApiController
    {
        
        private readonly static ILogger _log = ConfigUtil.CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IServiceTodoBL _todoBL;

        public TodoController(IServiceTodoBL todoBL)
        {
            //_todoBL = new ServiceTodoBL();
            _todoBL = todoBL;
        }

        [HttpGet()]
        public IHttpActionResult ReadTodo(int id)
        {
            try
            {             
                var todo = _todoBL.GetById(id);
                return Ok(todo);
            }
            catch (TodoBLException ex)
            {
                _log.Debug(ex.InnerException);
                return InternalServerError();
            }
        }

        [HttpGet()]
        public IHttpActionResult GetAll()
        {
            try
            {
                var todos = _todoBL.GetAll();
                return Ok(todos);
            }
            catch (TodoBLException ex)
            {
                _log.Debug(ex.InnerException);
                return InternalServerError();
            }
        }

        [HttpPost()]
        public IHttpActionResult AddTodo(Tarea todo)
        {
            try
            {           
                return Ok(_todoBL.Add(todo));
            }
            catch (TodoBLException ex)
            {
                _log.Debug(ex.InnerException);
                return InternalServerError();
            }
        }

        [HttpDelete()]
        public IHttpActionResult DeleteTodo(int id)
        {
            try
            {
                return Ok(_todoBL.DeleteById(id));
            }
            catch (TodoBLException ex)
            {
                _log.Debug(ex.InnerException);
                return InternalServerError();
            }

        }

        [HttpPut()]
        public IHttpActionResult UpdateTodo(int id, Tarea todo)
        {
            try
            {             
                return Ok(_todoBL.Update(id, todo));
            }
            catch (TodoBLException ex)
            {
                _log.Debug(ex.InnerException);
                return InternalServerError();
            }
        }

    }
}
