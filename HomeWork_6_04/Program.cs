using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_04
{
    /*
     * Программа с классом, у которого есть символьное и целочисленное поле.
     * В классе должны быть описаны версии конструктора с двумя аргументами
     * (целое число и символ - определяют значения полей),
     * а также с одним аргументом типа double.
     * В последнем случае действительная часть аргумента определяет код символа
     * (значение символьного поля), а дробная часть (с учетом десятых и сотых)
     * определяет значение целочисленного поля. Например, если аргументом
     * передается число 65.1267, то значением символьного поля будет символ 'A'
     * с кодом 65, а целочисленное поле получит 12
     * (в дробной части учитываются только десятые и сотые).
     */
    class MyClass
    {
        private int _value;
        private char _symbol;

        public int value
        {
            get { return _value; }
            set { _value = value; }
        }
        public char symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        public MyClass(int x, char s)
        {
            value = x;
            symbol = s;
        }
        public MyClass(double x)
        {
            value = (int)x;
            symbol = (char)((int)((x - (int)x) * 100));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(65.12667);
            Console.WriteLine($"Символ класса A: \"{A.symbol}\"");

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
