using System;

namespace Task1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i <= 9999; i++)
            {
                if ((i % 133 == 125) & (i % 134 == 111))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
