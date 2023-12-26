using System;

namespace HomeWork_6_09
{
    class MyClass
    {
        private static int _minValue = 0;
        private static int _maxValue = 2;
        private static double _aveValue = 1.0;
        public static int minValue
        {
            set { _minValue = value; }
            get { return _minValue; }
        }
        public static int maxValue
        {
            set { _maxValue = value; }
            get { return _maxValue; }
        }
        public static double aveValue
        {
            set { _aveValue = value; }
            get { return _aveValue; }
        }
        public static void determineMinMaxAverageValues(int[] arr)
        {
            maxValue = arr[0];
            minValue = arr[0];
            aveValue = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                    maxValue = arr[i];
                if (arr[i] < minValue)
                    minValue = arr[i];
                aveValue += arr[i];
            }
            aveValue = aveValue / arr.Length;
        }
        public static void show()
        {
            Console.WriteLine($"Максимальное значение:\t{maxValue}\n" +
                $"Минимальное значение:\t{minValue}\n" +
                $"Среднее значение:\t{aveValue}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass.determineMinMaxAverageValues(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            MyClass.show();


            // Завершение программы
            Console.Write("\n\n\nДля завершения работы программы нажмите Enter...");
            Console.ReadLine();
        }
    }
}
