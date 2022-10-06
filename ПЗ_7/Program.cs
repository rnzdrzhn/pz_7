using System;

namespace ПЗ_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int x = random.Next(-100, 100);
                if (x < 0)
                {
                    numbers[i] = x;
                    count++;
                }
            }
            Console.WriteLine("Количество отрицательных чисел = " + count);
            Array.Sort(numbers);
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                if (numbers[i] < 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            
           
            

        }
    }
}
