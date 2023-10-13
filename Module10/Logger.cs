using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    /// <summary>
    /// Класс логгера унаследованный от интерфейса ILogger
    /// </summary>
    public class Logger : ILogger
    {
        /// <summary>
        /// Неявно реализованный метод логирования сообщения об ошибке
        /// </summary>
        /// <param name="message">Сообщение об ошибке</param>
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Неявно реализованный метод логирования сообщения о произошедшем действии (событии). Не перепутать потом с Event и делегатами!!!
        /// </summary>
        /// <param name="message">Сообщение о событии</param>
        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
