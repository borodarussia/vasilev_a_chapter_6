using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_06
{
    class MyClass
    {
        private int _maxValue;
        private int _minValue;

        public int maxValue
        {
            set { _maxValue = value; }
            get { return _maxValue; }
        }
        public int minValue
        {
            set { _minValue = value; }
            get { return _minValue; }
        }
        public void setValues(int x)
        {
            maxValue = x;
            minValue = x - 5;
        }
        public void setValues(int x, int y)
        {
            if (x >= y)
            {
                maxValue = x;
                minValue = y;
                return;
            }

            maxValue = y;
            minValue = x;
        }
        public void show()
        {
            Console.WriteLine($"Максимальное значение:\t{maxValue}\n" +
                $"Минимальное значение:\t{minValue}");
        }
        public MyClass()
        {
            setValues(10);
        }
        public MyClass(int x)
        {
            setValues(x);
        }
        public MyClass(int x, int y)
        {
            setValues(x, y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            MyClass B = new MyClass(100);
            MyClass C = new MyClass(200, 300);

            A.show();
            B.show();
            C.show();

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
