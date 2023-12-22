using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingNum_6_6
{
    /*
     * Листинг 6.6
     * Знакомство со статическими полями и методами
     */

    // класс со статическим полем и методом
    class MyClass
    {
        // статическое поле:
        public static int code = 100;
        // статический мтеод:
        public static void show()
        {
            Console.WriteLine("Статическое поле: {0}", code);
        }
    }
    // класс с главным методом:
    internal class StaticDemo
    {
        // главный метод:
        static void Main(string[] args)
        {
            // вызов статического метода:
            MyClass.show();
            // обращение к статическому полю:
            MyClass.code = 200;
            // вызов статического метода:
            MyClass.show();

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
