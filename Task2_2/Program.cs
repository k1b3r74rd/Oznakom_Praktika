﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите промежуток");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число попыток");
            int k = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[] array = new int[1];
            Random r = new Random();
            for (int i = 0; i < 1; i++)
            {
                array[i] = r.Next(1, n);
            }

            for (int j = 0; j < k; j++)
            {
                Console.WriteLine("Введите число");
                int c = Convert.ToInt32(Console.ReadLine());
                if (c == array[0])
                {
                    Console.WriteLine("Ты выиграл");
                    break;
                }
                else
                {
                    if (c > array[0])
                    {
                        Console.WriteLine("Загаданное число меньше");
                        count += 1;
                    }
                    else
                    {
                        Console.WriteLine("Загаданое число больше");
                        count += 1;
                    }

                }
            }
            if (k == count)
            {
                Console.WriteLine("Попытки закончились, попробуй ещё раз");
            }

        }
    }
}
