﻿using System;

namespace Task2_5
{
    internal class Program
    {
        static Random rand = new Random();

        static float Rch(int a, int b)
        {
            return rand.Next(a + 1, b - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{i} - {Rch(a, b)};");
            }
        }
    }
}
