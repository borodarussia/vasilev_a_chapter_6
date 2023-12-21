using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingNum_6_4
{
    /*
     * Листинг 6.4
     * Использование конструктора
     */

    // описание класса с конструктором:
    class MyClass
    {
        // закрытые поля
        private int _num;       // целочисленное поле
        public char _symbol;    // символьное поле
        public string _txt;     // текстовое поле

        // открытый мтеод для отображения значений полей:
        public void show()
        {
            Console.WriteLine("Поля:\t{0},\t\'{1}\',\t\"{2}\"",
                _num, _symbol, _txt);
        }

        // конструктор без аргументов:
        public MyClass()
        {
            // значения полей:
            _num = 100;
            _symbol = 'a';
            _txt = "красный";
        }
        // конструктор с одни целочисленным аргументом:
        public MyClass(int num)
        {
            _num = num;
            _symbol = 'b';
            _txt = "желтый";
        }
        // конструктор с двумя аргументами:
        public MyClass(int n, char s)
        {
            // значения полей:
            _num = n;
            _symbol = s;
            _txt = "зеленый";
        }
        // конструктор с тремя аргументами:
        public MyClass(int n, char s, string t)
        {
            // значения полей:
            _num = n;
            _symbol = s;
            _txt = t;
        }
        // конструктор с одним текстовым аргументом:
        public MyClass (string t)
        {
            _num = 0;
            _symbol = 'z';
            _txt = t;
        }
    }
    // класс с главным методом:
    internal class ConstructorDemo
    {
        // главный метод
        static void Main(string[] args)
        {
            // создание объектов
            // вызывается конструктор без аргументов
            MyClass A = new MyClass();
            A.show();

            // вызывается конструктор с целочисленным аргументом:
            MyClass B = new MyClass(200);
            B.show();

            // вызывается конструктор с двумя аргументами:
            MyClass C = new MyClass(300, 'c');
            C.show();

            // вызывается конструктор с тремя аргументами:
            MyClass D = new MyClass(400, 'd', "синий");
            D.show();

            // вызывается конструктор с символьным аргументом:
            MyClass E = new MyClass('A');
            E.show();

            // вызывается конструктор с текстовым аргументом:
            MyClass F = new MyClass("серый");
            F.show();

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
