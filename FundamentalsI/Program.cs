using System;

namespace FundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop from 1 to 5 including 5
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            // loop from 1 to 5 excluding 5
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine($"FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz" + "i");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                }
            }
            int j = 1;
            while (j <= 100)
            {
                if (j % 3 == 0 || j % 5 == 0)
                {
                    if (j % 3 == 0 && j % 5 == 0)
                    {
                        Console.WriteLine($"FizzBuzz");
                        j++;
                    }
                    else if (j % 3 == 0)
                    {
                        Console.WriteLine("Fizz" + "j");
                        j++;
                    }
                    else if (j % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                        j++;
                    }
                }
                else
                {
                    j++;
                }

            }
        }
    }
}
