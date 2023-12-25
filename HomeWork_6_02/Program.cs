using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_02
{
    /*
     * Программа с классом, у которого есть два символьных поля
     * и метод. Он не возвращает результат, и у него нет аргументов.
     * При вызове метод выводит в консольное окно все символы из
     * кодовой таблицы, котороые находятся "между" символами, являющимися
     * значениями полей объекта (из которого вызывается метод). Например,
     * если полям объекта присвоены значения 'A' и 'D', то при вызове
     * метода в консольное окно должны выводиться все символы от 'A' до 'D'
     * включительно.
     */
    class MyClass
    {
        private char _startSymb;
        private char _endSymb;

        public MyClass(char startSymb, char endSymb)
        {
            _startSymb = startSymb;
            _endSymb = endSymb;
        }
        public MyClass(char startSymb)
        {
            _startSymb = startSymb;
            _endSymb = (char)((int)startSymb + 2);
        }
        public void show()
        {
            int startSymbCode = (int)_startSymb;
            int endSymbCode = (int) _endSymb;
            for(int i = 0; i <= (endSymbCode - startSymbCode); i++)
            {
                if(i == 0)
                {
                    Console.Write($"Список символов от {_startSymb} до {_endSymb}: [ {(char)(startSymbCode + i)} |");
                }
                else if(i == (endSymbCode - startSymbCode))
                {
                    Console.WriteLine($" {(char)(startSymbCode + i)} ]\n");
                }
                else
                {
                    Console.Write($" {(char)(startSymbCode + i)} |");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass('z');
            A.show();


            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
