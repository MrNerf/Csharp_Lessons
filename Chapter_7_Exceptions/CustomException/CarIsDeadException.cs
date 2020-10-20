using System;
using System.Runtime.Serialization;

// ReSharper disable CommentTypo

namespace CustomException
{
    /*
     * Пример правильной реализации класса исключения
     * Наличие атрибута обязательно
     * Конструкторы по умолчанию также являются обязательными
     * Метод message не переопределяется так как он передается в базовый конструктор родительского класса
     */
    [Serializable]
    public class CarIsDeadException : ApplicationException
    {
        #region Fields

        private readonly string _messageDetails = string.Empty;

        public DateTime ErrorDateTime { get; set; }
        public string CauseOfError { get; set; }


        #endregion

        #region Ctors

        public CarIsDeadException() { }

        public CarIsDeadException(string message) : base(message) { }

        public CarIsDeadException(string message, Exception innerException) : base(message, innerException) { }

        public CarIsDeadException(string message, string cause, DateTime time)
        {
            _messageDetails = message;
            CauseOfError = cause;
            ErrorDateTime = time;
        }

        protected CarIsDeadException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        #endregion

        public override string Message => $"Car error message {_messageDetails}";
    }
}
