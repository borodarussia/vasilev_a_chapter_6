using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_05
{
    /*
     * Программа с классом, у которого закрытое целочисленное поле.
     * Значение полю присваивается с помощью открытого метода.
     * Методу аргументом может передаваться целое число, а также
     * метод может вызываться без аргументов.
     * Если метод вызывается без аргументов, то поле получает нулевое значение.
     * Если метод вызывается с целочисленным аргументом, то это значение
     * присваивается полю. Однако если переданное аргументом методу значение превышает 100,
     * то значением присывается число 100.
     * Предусмотрите в классе конструктор, который работает по тому же принципу,
     * что и метод присваивания значения полю. Также в классе должен быть метод,
     * позволяющий проверить значение поля.
     */
    class MyClass
    {
        private int _value;
        public int value
        {
            get 
            {
                return _value;
            }
            set
            {
                if (value > 100)
                {
                    _value = 100;
                    return;
                }
                _value = value;
            }
        }
        public MyClass()
        {
            value = 0;
        }
        public MyClass(int inputValue)
        {
            value = inputValue;
        }
        public void show()
        {
            Console.WriteLine($"Значение: {value}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            MyClass B = new MyClass(254);
            MyClass C = new MyClass(43);

            A.show();
            B.show();
            C.show();

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
