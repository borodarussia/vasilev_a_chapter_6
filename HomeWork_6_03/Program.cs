using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_03
{
    /*
     * Программа с классом, у которого есть два целочисленных поля.
     * В классе должны быть описаны конструкторы,
     * позволяющие создавать объекты без передачи аргументов,
     * с передачей одного аргумента и с передачей двух аргументов
     */
    class MyClass
    {
        private int _firstValue;
        private int _secondValue;
        // свойства private _firstValue
        public int firstValue
        {
            set { _firstValue = value; }
            get { return _firstValue; }
        }
        // свойства private _secondValue
        public int secondValue
        {
            set { _secondValue = value; }
            get { return _secondValue; }
        }

        public MyClass() 
        {
            firstValue = 1;
            secondValue = 2;
        }
        public MyClass(int x)
        {
            firstValue = x;
            secondValue = x + 3;
        }
        public MyClass(int x, int y)
        {
            firstValue = x;
            secondValue = y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            MyClass B = new MyClass(15);
            MyClass C = new MyClass(10, 25);

            Console.WriteLine($"Класс A:\t{A.firstValue}\t{A.secondValue}");
            Console.WriteLine($"Класс B:\t{B.firstValue}\t{B.secondValue}");
            Console.WriteLine($"Класс C:\t{C.firstValue}\t{C.secondValue}");

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
