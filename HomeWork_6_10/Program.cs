using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_10
{
    class MyClass
    {
        public const double Pi = 3.14159265358979; // константа (число "пи")
        private static int _numberOfIterations = 30; // статическое поле (граница суммы)
        // статический метод для вычисления косинуса:
        public static double cos(double x)
        {
            double s = 0;
            for(int i = 0; i <= _numberOfIterations; i++)
                s += Math.Pow(-1, i) * Math.Pow(x, i * 2) / RecursionFactorial(2 * i);

            return s;
        }
        public static double sh(double x)
        {
            double s = 0;

            for (int i = 0; i <= _numberOfIterations; i++)
                s += Math.Pow(x, 2 * i + 1) / RecursionFactorial(2 * i + 1);

            return s;
        }
        public static double ch(double x)
        {
            double s = 0;

            for (int i = 0; i <= _numberOfIterations; i++)
                s += Math.Pow(x, 2 * i) / RecursionFactorial(2 * i);

            return s;
        }
        private static Int64 RecursionFactorial(int x)
        {
            if (x == 0 || x == 1)
                return 1;

            return x * RecursionFactorial(x - 1);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = MyClass.Pi / 3;
            Console.WriteLine($"Функция cos:\t\t\t{MyClass.cos(x)}\n" +
                $"Контрольное значение cos:\t{Math.Cos(x)}");

            Console.WriteLine($"\n\nФункция sh:\t\t\t{MyClass.sh(x)}\n" + 
                $"Контрольное значение sh:\t{Math.Sinh(x)}");

            Console.WriteLine($"\n\nФункция sh:\t\t\t{MyClass.ch(x)}\n" +
                $"Контрольное значение sh:\t{Math.Cosh(x)}");

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
