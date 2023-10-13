using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    /// <summary>
    /// Класс чтения вводимого с клавиатуры числа
    /// </summary>
    internal class ConsoleReader
    {
        static ILogger ?Logger { get; set; }

        /// <summary>
        /// Метод, получающий введеное с клавиатуры число
        /// </summary>
        /// <param name="msg">Часть текста, выводимая в качестве преглашения для ввода. Например, для получения пришлашения "Введите первое слагаемое" необходимо передать "первое слагаемое"</param>
        /// <param name="flag">Выходной булевый параметр, опеределяющий было ли введено число или пользователь отказался от попытки ввода после неудачи</param>
        /// <returns>Возвращаемое методом значение - введеное пользователем число. По умолчанию - 0</returns>
        internal static double GetNum(string msg, out bool flag)
        {
            Logger = new Logger();

            do
            {
                Console.Write($"Введите {msg}: ");
                try
                {

                    if (double.TryParse(Console.ReadLine(), out double result))
                    {
                        flag = true;
                        return result;
                    }
                    else
                    {
                        throw new InvalidValueException("Некорректный формат числа");
                    }
                }
                catch (Exception ex) //Исключение сделал общим, а не только своим
                {
                    Logger?.Error(ex.Message);
                    //Console.WriteLine(ex.Message);
                    if (Repeat() == false)
                    {
                        flag = false;
                        return 0;
                    }
                    else { Console.WriteLine(); }    
                }
            }
            while (true);
        }

        /// <summary>
        /// Метод повтора ввода в случае ошибки
        /// </summary>
        /// <returns>Возвращаемое значение: true - повторить ввод, false - не повторять</returns>
        private static bool Repeat() 
        {
            Logger = new Logger ();

            Console.WriteLine("Желаете повторить ввод? (Y/N)");
            do
            {
                switch (Console.ReadKey(true).Key) //Без параметра true подавляется первый символ в выводимой строке после нажатия Escape
                {
                    case ConsoleKey.Y:
                        return true;
                    case ConsoleKey.N:
                        return false;
                    case ConsoleKey.Escape: //последний шанс выбраться
                        return false;
                    default:
                        Logger?.Error("\nНажмите \"Y\" для повтора ввода числа или \"N\" для выхода. Также можно выйти, нажав Esc");
                        //Console.WriteLine("\nНажмите \"Y\" для повтора ввода числа или \"N\" для выхода. Также можно выйти, нажав Esc");
                        break;
                }
            }
            while (true);
        }
    }
}
