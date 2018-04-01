using System;
using System.Runtime.Serialization;

namespace Task1
{
    [Serializable]
    public class FormatApplicationException : Exception
    {
        public FormatApplicationException()
        {
        }

        public FormatApplicationException(string message) : base(message)
        {
        }

        public FormatApplicationException(string message, Exception inner) : base(message, inner)
        {
        }

        protected FormatApplicationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

    }
}
