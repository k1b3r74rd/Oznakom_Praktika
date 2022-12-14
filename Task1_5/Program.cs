using System;

namespace Task1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[18];
            int x = 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int a = 0;            
            bool matched = true;
            while ((matched) & (a < 17))
            {
                if (array[a] == array[a + 1])
                {
                    x++;
                    a++;
                }
                else
                {
                    matched = false;
                }
            }
            Console.WriteLine(x);

        }
    }
}
