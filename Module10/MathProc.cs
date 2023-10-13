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
        /// <summary>
        /// Метод нахождения суммы, который не был реализован по умолчанию в интерфейсе
        /// </summary>
        /// <param name="a">>Слагаемое 1</param>
        /// <param name="b">>Слагаемое 2</param>
        /// <returns></returns>
        double IMathProc.SumImplementItYourself(double a, double b) { return a + b; } //=> Нереализованный по-умолчанию метод интерфейса надо реализовать самому
    }
}
