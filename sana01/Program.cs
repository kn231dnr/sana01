using System;
using System.Text;


namespace LinearExpressions
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
            Console.WriteLine("Введіть значення c");
            double c = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення d");
            double d = Double.Parse(Console.ReadLine());
            double x = ((a + 2 * d - c + d) / (double)(c * d)) + (a + b / (double)c - d) - (Math.Pow(a, 2) / Math.Pow(b, 2));
            Console.WriteLine($"x = {x}");
            double y = (5 * (a + b) * (c - d) / (1.0/2.0 * c)) + (Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
            Console.WriteLine($"y = {y}");
            double z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
            Console.WriteLine($"z = {z}");
        }
    }
}
