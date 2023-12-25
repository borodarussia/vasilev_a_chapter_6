using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_6_9
{
    // класс с перегрузкой конструкторов:
    class MyClass
    {
        // целочисленные поля:
        public int alpha;
        public int bravo;
        // конструктор с одним аргументом:
        public MyClass(int a)
        {
            // сообщение в консольном окне:
            Console.WriteLine("Конструктор с одним аргументом");
            // значение полей:
            alpha = a;
            bravo = alpha;
            // отображение значений полей
            Console.WriteLine($"Оба поля равны: {alpha}");
        }
        // конструктор с двумя аргументами:
        public MyClass(int a, int b): this(a)
        {
            // сообщение в консольном окне
            Console.WriteLine("Конструктор с двумя аргументами");
            // значение второго поля:
            bravo = b;
            // отображение значений полей:
            Console.WriteLine($"Поля {alpha} и {bravo}");
        }
        // конструктор без аргументов:
        public MyClass(): this(400, 500)
        {
            // сообщение в консольном окне:
            Console.WriteLine("Конструктор без аргументов");
            // отображение значений полей:
            Console.WriteLine($"Значения {alpha} и {bravo}");
        }
    }
    internal class ConstrAndThisDemo
    {
        // главный метод:
        static void Main(string[] args)
        {
            // вызов конструктора с одним аргументом:
            MyClass A = new MyClass(100);
            Console.WriteLine();
            // Вызов конструктора с двумя аргументами:
            MyClass B = new MyClass(200, 300);
            Console.WriteLine();
            // Вызов конструктора без аргументов:
            MyClass C = new MyClass();

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
