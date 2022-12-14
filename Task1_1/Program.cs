using System;

namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currDir = Environment.CurrentDirectory.ToString();
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(currDir);
            Console.WriteLine(path);
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double angle = Math.Atan2(y, x)*180.0/Math.PI;
            Console.WriteLine(angle);
        }
    }
}
