using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    internal class DayException : Exception
    {
        private int day;

        public DayException()
        {
        }

        public DayException(int day)
        {
            this.day = day;
        }

        public DayException(string? message) : base(message)
        {
        }

        public DayException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}