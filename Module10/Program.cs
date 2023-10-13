namespace Module10
{
    internal class Program
    {
        static void Main()
        {
            double num1 = ConsoleReader.GetNum("первое слагаемое", out bool flag);
            if (flag == false ) { GoodBye(-1); }

            double num2 = ConsoleReader.GetNum("второе слагаемое", out flag);
            if (flag == false) { GoodBye(-1); }

            MathProc mathProc = new(); //Оказывается так можно https://learn.microsoft.com/ru-ru/dotnet/fundamentals/code-analysis/style-rules/ide0090
            Console.WriteLine ($"Сумма чисел {num1} и {num2} равна {((IMathProc)mathProc).Sum(num1, num2)}"); //Реализованный в интерфейсе метод
            Console.WriteLine($"И еще раз. Сумма чисел {num1} и {num2} равна {((IMathProc)mathProc).SumImplementItYourself(num1, num2)}"); //Реализованный в классе метод
            
            GoodBye(0);
        }

        /// <summary>
        /// Метод завершения работы
        /// </summary>
        /// <param name="exitCode">Код завершение. 0 - штатное завершение. -1 - отказ от ввода числа</param>
        private static void GoodBye(int exitCode)
        {
            switch (exitCode) {
                case -1:
                    Console.WriteLine("\nЖаль, что Вы передумали. До свидания!");
                    break;
                case 0:
                    Console.WriteLine("\nСпасибо за использование нашего калькулятора. До свидания!");  
                    break;
                default:
                    break;
            }

            Console.Write("Нажмите любую кнопку для выхода...");
            Console.ReadKey();
            System.Environment.Exit(exitCode);
        }

    }
}
///Далее...
///Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
///Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.