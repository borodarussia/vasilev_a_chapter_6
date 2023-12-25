using System;

namespace HomeWork_6_01
{
    /*
     * Программа с классом, в котором есть закрытое символьное поле
     * и три открытых метода.
     * Один из методов позволяет присвоить значение полю.
     * Еще один метод при вызове возвращает результатом код символа.
     * Третий метод позволяет вывести в консольное окно
     * символ (значение поля) и его код.
     */
    class MyClass
    {

        private char _symb;

        public void set_symb(char symbol)
        {
            _symb = symbol;
        }

        public char get_symb()
        {
            return _symb;
        }

        public void show_symb()
        {
            Console.WriteLine($"Символ: {_symb}\nКод символа: {(int)_symb}");
        }

        public MyClass()
        {
            _symb = 'a';
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();

            A.show_symb();

            A.set_symb('b');
            Console.WriteLine();
            A.show_symb();

            Console.WriteLine($"\nСимвол объекта A: {A.get_symb()}");

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
