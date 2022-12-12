using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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

            for (int i = 0; i < array.Length-i; i++)
            {
                if (array[i] == array[i + 1])
                {
                    x++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(x);
        }
    }
}
