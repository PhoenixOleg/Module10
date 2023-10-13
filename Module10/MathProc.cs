using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    /// <summary>
    /// Класс арифметических операций, наследующий интерфейс IMathProc
    /// </summary>
    public class MathProc : IMathProc
    {
        public ILogger ?Logger { get; set; }

        /// <summary>
        /// Метод нахождения суммы, который не был реализован по умолчанию в интерфейсе
        /// </summary>
        /// <param name="a">>Слагаемое 1</param>
        /// <param name="b">>Слагаемое 2</param>
        /// <returns>Возвращаем сумму чисел</returns>
        double IMathProc.SumImplementItYourself(double a, double b, ILogger logger) //=> Нереализованный по-умолчанию метод интерфейса надо реализовать самому
        {
            Logger?.Event($"Считаем сумму {a} + {b}");
            try //чуть не забыл про возможность переполнения
            {
                return a + b;
            }
            catch (OverflowException ex)
            {
                Logger?.Error (ex.Message );
                return 0;
            }            
        } 
    }
}
