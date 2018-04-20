using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Business.Logic.Errors
{
    [Serializable()]
    public class TodoBLException : System.Exception
    {
        public TodoBLException() :
            base() { }

        public TodoBLException(string message)
            : base(message) { }

        public TodoBLException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public TodoBLException(string message, Exception innerException)
            : base(message, innerException) { }

        public TodoBLException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected TodoBLException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
