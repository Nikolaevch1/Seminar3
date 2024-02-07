using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 20, 50, 10, 10, 60, 30, 70, 98, 20, 40};
            int count = 0;

            foreach (int element in array)
            {
                if (element >= 10 && element <= 90)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество элементов в отрезке [10, 90]: {count}");
            Console.ReadKey();
        }
    }
}
