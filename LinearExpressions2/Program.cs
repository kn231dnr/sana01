using System;
using System.Text;


namespace LinearExpressions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть значення a");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення b");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення m");
            double m = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення n");
            double n = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення x");
            double x = Double.Parse(Console.ReadLine());
            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(n, 2) - m);
            Console.WriteLine($"z1 = {z1}");
            double z2 = Math.Sqrt(m) - Math.Sqrt(n) / m;
            Console.WriteLine($"z2 = {z2}");
        }
    }
}
