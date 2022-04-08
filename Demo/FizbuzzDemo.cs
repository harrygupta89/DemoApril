using System;

namespace Demo
{
    class FizbuzzDemo
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + "= fizzbuzz");
                else if (i % 3 == 0)
                    Console.WriteLine(i + "= fizz");
                else
                    Console.WriteLine(i + "= buzz");
            }
            Console.Read();
        }
    }
}
