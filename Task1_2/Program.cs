using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x0, y0, xn, yn, xk, yk;
            x0 = Convert.ToInt32(Console.ReadLine());
            y0 = Convert.ToInt32(Console.ReadLine());
            xn = Convert.ToInt32(Console.ReadLine());
            yn = Convert.ToInt32(Console.ReadLine());
            xk = Convert.ToInt32(Console.ReadLine());
            yk = Convert.ToInt32(Console.ReadLine());
            
            if (xn >= x0) // Начальная точка
            {
                if (yn >= y0)
                {
                    Console.WriteLine("Начальная точка находится в I четверти.");
                }
                else
                {
                    Console.WriteLine("Начальная точка находится в II четверти.");
                }
            }
            else 
            {
                if (yn >= y0)
                {
                    Console.WriteLine("Начальная точка находится в IV четверти.");
                }
                else
                {
                    Console.WriteLine("Начальная точка находится в III четверти.");
                }
            }

            if (xk >= x0) // Конечная точка
            {
                if (yk >= y0)
                {
                    Console.WriteLine("Конечная точка находится в I четверти.");
                }
                else
                {
                    Console.WriteLine("Конечная точка находится в II четверти.");
                }
            }
            else
            {
                if (yk >= y0)
                {
                    Console.WriteLine("Конечная точка находится в IV четверти.");
                }
                else
                {
                    Console.WriteLine("Конечная точка находится в III четверти.");
                }
            }
        }
    }
}
