using System;
using System.Runtime.Serialization;

namespace _24_CriandoExcecaoPersonalizada
{
    [Serializable]
    internal class NotaInvalidaException : Exception
    {
        public NotaInvalidaException()
        {
        }

        public NotaInvalidaException(string message) : base(message)
        {
        }

        public NotaInvalidaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotaInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}