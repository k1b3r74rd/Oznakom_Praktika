using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= x; i++) 
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
