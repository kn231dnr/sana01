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
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення c");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення d");
            int d = int.Parse(Console.ReadLine());
            double x = ((a + 2 * d - c + d) / (double)(c * d)) + (a + b / (double)c - d) - (Math.Pow(a, 2) / Math.Pow(b, 2));
            Console.WriteLine($"x = {x}");
        }
    }
}
