using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Todo.Common.Logic.Logger;
using Todo.Common.Logic.Model;
using Todo.Common.Logic.Util;
using Todo.DataAcces.Dao.Context;
using Todo.DataAcces.Dao.Errors;

namespace Todo.DataAcces.Dao
{
    public class RepositoryTodo<T> : IRepositoryTodo<T>
    {
        private readonly ILogger _log = ConfigUtil.CreateInstanceClassLog(MethodBase.GetCurrentMethod().DeclaringType);
        private IDatabase database;

        public int Delete(int id)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            database = new SqlServerDatabase();
       
            try
            {
                using (IDbConnection connection = database.CreateOpenConnection())
                {
                    var sqlCommand = "DELETE FROM TASKS WHERE Id = @IDTarea";
                    using (IDbCommand command = database.CreateCommand(sqlCommand, connection))
                    {
                        database.AddParameter(command, "@IDTarea", id);
                        return (Int32)command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                _log.Error(e.Message + e.StackTrace);
                throw new TodoDaoException("Error delete tarea: ", e.InnerException);
            }
            catch (Exception e)
            {
                _log.Error(e.Message + e.StackTrace);
                throw new TodoDaoException("Error delete tarea: ", e.InnerException);
            }
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Insert(T item)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            database = new SqlServerDatabase();
            var todo = item as Tarea;

            try
            {
                using (IDbConnection connection = database.CreateOpenConnection())
                {
                    
                    var sqlCommand = "INSERT INTO TASKS ([Guid],[Title],[Comment],[DateCreate],[DateFinal],[DateUpdate]) " +
                        "VALUES (@Guid, @Title, @Comment, @DateCreate, @DateFinal, @DateUpdate)";
                    using (IDbCommand command = database.CreateCommand(sqlCommand, connection))
                    {
                        database.AddParameter(command, "@Guid", todo.Guid);
                        database.AddParameter(command, "@Title", todo.Title);
                        database.AddParameter(command, "@Comment", todo.Comment);
                        database.AddParameter(command, "@DateCreate", todo.DateCreate);
                        database.AddParameter(command, "@DateFinal", todo.DateFinal);
                        database.AddParameter(command, "@DateUpdate", todo.DateUpdate);
                        command.ExecuteNonQuery();
                    }

                    sqlCommand = "SELECT * FROM TASKS WHERE Guid = @Guid";
                    using (IDbCommand command = database.CreateCommand(sqlCommand, connection))
                    {
                        database.AddParameter(command, "@Guid", todo.Guid);
                        using (IDataReader reader = command.ExecuteReader())
                        {
                            var tarea = new Tarea();
                            while (reader.Read())
                            {
                                tarea.Id = Convert.ToInt32(reader["Id"].ToString());
                                tarea.Guid = reader["Guid"].ToString();
                                tarea.Title = reader["Title"].ToString();
                                tarea.Comment = reader["Comment"].ToString();
                                tarea.DateCreate = Convert.ToDateTime(reader["DateCreate"].ToString());
                                tarea.DateFinal = Convert.ToDateTime(reader["DateFinal"].ToString());
                                tarea.DateUpdate = Convert.ToDateTime(reader["DateUpdate"].ToString());
                            }

                            return (T)Convert.ChangeType(tarea, typeof(T));
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                _log.Error(e.Message + e.StackTrace);
                throw new TodoDaoException("Error insert tarea: ", e.InnerException);
            }
            catch (Exception e)
            {
                _log.Error(e.Message + e.StackTrace);
                throw new TodoDaoException("Error insert tarea: ", e.InnerException);
            }

        }
        public T SelectById(int id)
        {
            _log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name);
            database = new SqlServerDatabase();

            try
            {
                using (IDbConnection connection = database.CreateOpenConnection())
                {
                    var sqlCommand = "SELECT * FROM TASKS WHERE Id = @IDTarea";
                    using (IDbCommand command = database.CreateCommand(sqlCommand, connection))
                    {
                        database.AddParameter(command, "@IDTarea", id);

                        using (IDataReader reader = command.ExecuteReader())
                        {
                            var tarea = new Tarea();
                            while (reader.Read())
                            {
                                tarea.Id = Convert.ToInt32(reader["Id"].ToString());
                                tarea.Guid = reader["Guid"].ToString();
                                tarea.Title = reader["Title"].ToString();
                                tarea.Comment = reader["Comment"].ToString();
                                tarea.DateCreate = Convert.ToDateTime(reader["DateCreate"].ToString());
                                tarea.DateFinal = Convert.ToDateTime(reader["DateFinal"].ToString());
                                tarea.DateUpdate = Convert.ToDateTime(reader["DateUpdate"].ToString());
                            }

                            return (T)Convert.ChangeType(tarea, typeof(T));
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                _log.Error(e.Message + e.StackTrace);
                throw new TodoDaoException("Error select by id tarea: ", e.InnerException);
            }
            catch (Exception e)
            {
                _log.Error(e.Message + e.StackTrace);
                throw new TodoDaoException("Error select by id tarea: ", e.InnerException);
            }
        }

        public T Update(T id)
        {
            throw new NotImplementedException();
        }
    }
}
