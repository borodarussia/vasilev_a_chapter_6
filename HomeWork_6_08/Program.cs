using System;

namespace HomeWork_6_08
{
    class MyClass
    {
        private int _value;
        public int value
        {
            get { return _value; }
            set { _value = value; }
        }
        public MyClass()
        {
            value = 0;
        }
        public void show()
        {
            Console.WriteLine($"Текущее значение: {value}");
            value += 1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            A.show();
            A.show();
            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
