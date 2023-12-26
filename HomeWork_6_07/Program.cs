using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6_07
{
    class MyClass
    {
        private string _txt;
        private char _symbol;
        public string txt
        {
            get { return _txt; }
            set { _txt = value; }
        }
        public char symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }


        public void inputInfo(string t)
        {
            txt = t;
        }
        public void inputInfo(char s)
        {
            symbol = s;
        }
        public void inputInfo(char[] sArr)
        {
            string exportTxt = "";
            foreach(char s in sArr)
            {
                exportTxt += s;
            }
            txt = exportTxt;
        }
        public void show()
        {
            Console.WriteLine($"Строка: {txt}\nСимвол: {symbol}");
        }
        public MyClass()
        {
            txt = "example";
            symbol = 'a';
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            MyClass B = new MyClass();
            MyClass C = new MyClass();

            A.inputInfo("Проверочный текст");
            A.show();
            A.inputInfo('l');
            A.show();
            char[] symbArra = { 'l', 'a', 'z', 'y' };        
            A.inputInfo(symbArra);
            A.show();

            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
