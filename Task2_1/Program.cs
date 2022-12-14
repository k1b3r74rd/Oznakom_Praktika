﻿using System;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int n = int.Parse(Console.ReadLine());
            DateTime date1 = new DateTime(n, 1, 31);
            Console.WriteLine(getLastThursday(date1));
            DateTime date2 = new DateTime(n, 2, 28);
            Console.WriteLine(getLastThursday(date2));
            DateTime date3 = new DateTime(n, 3, 31);
            Console.WriteLine(getLastThursday(date3));
            DateTime date4 = new DateTime(n, 4, 30);
            Console.WriteLine(getLastThursday(date4));
            DateTime date5 = new DateTime(n, 5, 31);
            Console.WriteLine(getLastThursday(date5));
            DateTime date6 = new DateTime(n, 6, 30);
            Console.WriteLine(getLastThursday(date6));
            DateTime date7 = new DateTime(n, 7, 31);
            Console.WriteLine(getLastThursday(date7));
            DateTime date8 = new DateTime(n, 8, 31);
            Console.WriteLine(getLastThursday(date8));
            DateTime date9 = new DateTime(n, 9, 30);
            Console.WriteLine(getLastThursday(date9));
            DateTime date10 = new DateTime(n, 10, 31);
            Console.WriteLine(getLastThursday(date10));
            DateTime date11 = new DateTime(n, 11, 30);
            Console.WriteLine(getLastThursday(date11));
            DateTime date12 = new DateTime(n, 12, 31);
            Console.WriteLine(getLastThursday(date12));
        }
        static DateTime getLastThursday(DateTime dt)
        {
            while (dt.DayOfWeek != DayOfWeek.Thursday)
            {
                dt = dt.AddDays(-1);
            }
            return dt;
        }
    }
}

