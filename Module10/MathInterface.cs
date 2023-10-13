using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    /// <summary>
    /// Интерфейс арифметических операций
    /// </summary>
    public interface IMathProc
    {
        /// <summary>
        /// Метод суммирования с реализованным по умолчанию функционалом 
        /// </summary>
        /// <param name="a">Слагаемое 1</param>
        /// <param name="b">Слагаемое 2</param>
        /// <param name="logger">Переменная для передачи сообщения в класс логирования</param>
        /// <returns>Возвращаем сумму чисел</returns>

        public ILogger Logger { get; set; }
        
        public double Sum(double a, double b, ILogger logger)
        {
            Logger = logger;
            Logger.Event($"Считаем сумму {a} + {b}");
            try //чуть не забыл про возможность переполнения
            {
                return a + b;
            }
            catch (OverflowException ex)
            {
                Logger?.Error(ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// Метод суммирования без реализации функционала (его необходимо реализовать в классе-наследнике) 
        /// </summary>
        /// <param name="a">Слагаемое 1</param>
        /// <param name="b">Слагаемое 2</param>
        /// <param name="logger">Переменная для передачи сообщения в класс логирования</param>
        /// <returns>Возвращаем сумму чисел</returns>
        public double SumImplementItYourself(double a, double b, ILogger logger);
    }

    //методы вычитания, умножения, деления и т. п.
}
