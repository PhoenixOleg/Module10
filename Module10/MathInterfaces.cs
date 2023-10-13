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
        /// <returns></returns>
        public double Sum(double a, double b)
        {
            return (a + b);
        }

        /// <summary>
        /// Метод суммирования без реализации функционала (его необходимо реализовать в классе-наследнике) 
        /// </summary>
        /// <param name="a">Слагаемое 1</param>
        /// <param name="b">Слагаемое 2</param>
        /// <returns></returns>
        public double SumImplementItYourself(double a, double b);
    }

    //методы вычитания, умножения, деления и т. п.
}
