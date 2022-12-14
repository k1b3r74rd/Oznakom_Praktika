﻿using System;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] m2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Random rand = new Random();
            while (m1[0] == 1 || m1[1] == 2 || m1[2] == 3 || m1[3] == 4 || m1[4] == 5 || m1[5] == 6 || m1[6] == 7 || m1[7] == 8 || m1[8] == 9 || m1[9] == 10)
            {
                for (int i = 0; i <= 9; i++)
                {
                    int x = rand.Next(i + 1);
                    int temp = m1[i];
                    m1[i] = m1[x];
                    m1[x] = temp;
                }
            }
            for (int i = 0; i < m1.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{m1[i]}");
            }

        }
    }
}
