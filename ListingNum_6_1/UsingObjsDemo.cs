using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingNum_6_1
{
    /*
     * Листинг номер 6.1
     * Описание класса и создание объектов
     */

    // описание класса
    class MyClass
    {
        // целочисленное поле:
        public int number;
        // символьное поле:
        public char symbol;
        // метод:
        public void show()
        {
            // отображение значения целочисленного поля:
            Console.WriteLine("Целочисленное поле:\t{0}", number);
            // отображение значения символьного поля:
            Console.WriteLine("Символьное поле:\t{0}", symbol);
        }
    }

    internal class UsingObjsDemo
    {
        // главный метод:
        static void Main(string[] args)
        {
            // первый объект:
            MyClass A = new MyClass();
            // Объектная переменная:
            MyClass B;
            // второй объект:
            B = new MyClass();
            // присваивание значений полям первого объекта:
            A.number = 123;
            A.symbol = 'A';
            // присвание значений полям второго объекта:
            B.number = 321;
            B.symbol = 'B';
            // вызов методов:
            Console.WriteLine("Первый объект:");
            A.show();
            Console.WriteLine("\n\nВторой объект:");
            B.show();


            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
