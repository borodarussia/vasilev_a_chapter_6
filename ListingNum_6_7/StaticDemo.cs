using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingNum_6_7
{
    /*
     * Листинг 6.7
     * Использование статических полей и методов
     */
    class MyMath
    {
        // константное поле (число "пи"):
        public const double Pi = 3.141592;
        // закрытое статическое поле (граница суммы):
        private static int N = 100;
        // статический метод для вычисления экспоненты:
        public static double exp(double x)
        {
            // сумма и добавка к сумме
            double s = 0, q = 1;
            // вычисление суммы:
            for (int i = 0; i <= N; i++)
            {
                s += q;             // прибавление добавки к сумме
                q *= x / (i + 1);   // добавка для следующей итерации
            }
            // результат:
            return s;
        }
        // статический метод для вычисления синуса:
        public static double sin(double x)
        {
            // сумма и добавка к сумме
            double s = 0, q = x;
            // вычисление суммы:
            for(int i = 0; i <= N; i++)
            {
                s += q;         // прибавление добавки к сумме
                q *= (-1) * x * x / (2 * i + 2) / (2 * i + 3); // добавка для следующей итерации
            }

            return s; // результат
        }
    }


    internal class StaticDemo
    {
        static void Main(string[] args)
        {
            double z = 1.0; // аргумент для статических методов
            // вычисление экспоненты:
            Console.WriteLine("Значение, определенное при помощи ряда exp({0}):\t{1}", z, MyMath.exp(z));
            Console.WriteLine("Контрольное значение exp({0}):\t\t\t{1}", z, Math.Exp(z));
            Console.WriteLine("Отклонение:\t\t\t\t\t{0}", ((MyMath.exp(z) - Math.Exp(z)) / Math.Exp(z) * 100));

            z = MyMath.Pi / 4; // новое значение аргумента
            //вычисление синуса:
            Console.WriteLine("\n\nЗначение, определенное при помощи ряда sin({0}):\t{1}", z, MyMath.sin(z));
            Console.WriteLine("Контрольное значение sin({0}):\t\t\t{1}", z, Math.Sin(z));
            Console.WriteLine("Отклонение:\t\t\t\t\t\t{0}",((MyMath.sin(z) - Math.Sin(z)) / Math.Sin(z) * 100));

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
