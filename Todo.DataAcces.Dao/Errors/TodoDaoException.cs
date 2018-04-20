using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Todo.DataAcces.Dao.Errors
{
    [Serializable()]
    public class TodoDaoException : System.Exception
    {
        public TodoDaoException()
            : base() { }

        public TodoDaoException(string message)
            : base(message) { }

        public TodoDaoException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public TodoDaoException(string message, Exception innerException)
            : base(message, innerException) { }

        public TodoDaoException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected TodoDaoException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
