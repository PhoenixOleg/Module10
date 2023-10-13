using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    /// <summary>
    /// Класс пользовательского исключения некорректного ввода
    /// </summary>
    internal class InvalidValueException : Exception
    {
        public InvalidValueException() { }

        public InvalidValueException(string message) : base(message) { }

        public InvalidValueException(string message, Exception inner) : base(message, inner) { } //Конструктор для обработки внутренних исключений

    }
}
