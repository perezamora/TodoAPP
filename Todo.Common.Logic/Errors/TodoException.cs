using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Common.Logic.Errors
{
    [Serializable()]
    public class TodoException : System.Exception
    {
        public TodoException()
            : base() { }

        public TodoException(string message)
            : base(message) { }

        public TodoException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public TodoException(string message, Exception innerException)
            : base(message, innerException) { }

        public TodoException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected TodoException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
