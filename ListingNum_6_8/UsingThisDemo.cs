using System;

namespace ListingNum_6_8
{
    /*
     * Листинг 6.8
     * Ключевое слово this
     */
    class MyClass
    {
        private int _code; // закрытое целочисленное поле
                           // открытый метод get:
        public int get()
        {
            // использовано ключевое слово this:
            return this._code;
        }
        // открытый метод set:
        public void set(int code)
        {
            // использовано ключевое слово this:
            this._code = code;
        }
        // конструктор:
        public MyClass(int code)
        {
            // использованое ключевое слово this:
            this._code = code;
            // использовано ключевое слово this:
            Console.WriteLine($"Создан объект: {this.get()}");
        }
    }
    // класс с главным методом:
    internal class UsingThisDemo
    {
        // главный метод        
        static void Main(string[] args)
        {
            // создание объекта:
            MyClass obj = new MyClass(100);
            // присваивание значения полю:
            obj.set(200);
            // проверка значения поля:
            Console.WriteLine($"Новое значение: {obj.get()}");
            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
