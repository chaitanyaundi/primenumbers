using System;
using System.Collections.Generic;

namespace primenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chaitanya");
            var box = new List<int>();
            Console.Write("Enter the number for the range of primes till this number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j < num; j++)
            {
                if (Factors(j) == 2)
                {
                    box.Add(j);
                }
            }
            foreach (var item in box)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total number of primes till {num} are {box.Count}.");
        }

        public static int Factors(int x)
        {
            var box2 = new List<int>();
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    box2.Add(i);
                }
            }
            return box2.Count;
        }


    }
}
