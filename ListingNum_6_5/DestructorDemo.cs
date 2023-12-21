using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingNum_6_5
{
    /*
     * Листинг 6.5
     * Использование деструктора
     */
    
    // класс с конструктором и деструктором
    class MyClass
    {
        // закрытое текстовое поле:
        private string _name;
        // конструктор:
        public MyClass(string txt)
        {
            // присваивание значения полю:
            _name = txt;
            // отображение сообщения:
            Console.WriteLine("Создан объект \"{0}\"", _name);
        }
        // деструктор:
        ~MyClass()
        {
            // отображение сообщения:
            Console.WriteLine("Удален объект: \"{0}\"", _name);
            // Console.WriteLine("Для продолжения работы программы нажмите Enter...");
            // Console.Read();
        }
    }

    // класс с главным методом:
    internal class DestructorDemo
    {
        // статический метод:
        static void maker(string txt)
        {
            // создание анонимного объекта
            new MyClass(txt);
        }
        // главный метод:
        static void Main(string[] args)
        {
            // создание объекта:
            MyClass A = new MyClass("Первый");
            // создание анонимного объекта:
            new MyClass("Второй");
            // новый объект
            A = new MyClass("Третий");
            // вызов статического метода
            maker("Четвертый");
            // новый объект:
            A = new MyClass("Пятый");

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
