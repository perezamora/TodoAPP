using System;
using System.Runtime.Serialization;

namespace Todo.DataAcces.Dao
{
    [Serializable]
    internal class TodoBLException : Exception
    {
        public TodoBLException()
        {
        }

        public TodoBLException(string message) : base(message)
        {
        }

        public TodoBLException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TodoBLException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}