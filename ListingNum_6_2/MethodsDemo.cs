using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingNum_6_2
{
    /*
     * Листинг 6.3
     * Закрытые члены класса и перегрузка методов
     */
    
    // описание класса:
    class MyClass
    {
        // закрытое целочисленное поле:
        private int _number;
        // закрытое символьное поле:
        private char _symbol;
        // открытый метод для отображения значения полей:
        public void show()
        {
            Console.WriteLine("Поля объекта: {0} и {1}", _number, _symbol);
        }
        // открытый метод для присваивания значений полям
        // версия с двумя аргументами:
        public void set(int n, char s)
        {
            _number = n;
            _symbol = s;
        }
        // версия с одним целочисленным аргументом:
        public void set(int n)
        {
            _number = n;
            _symbol = 'B';
        }
        // версия без аргументов
        public void set()
        {
            set(100, 'A');
        }
    }

    internal class MethodsDemo
    {
        static void Main(string[] args)
        {
            // создания объекта:
            MyClass obj = new MyClass();
            obj.set();
            obj.show();
            obj.set(200);
            obj.show();
            obj.set(300, 'C');
            obj.show();


            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
