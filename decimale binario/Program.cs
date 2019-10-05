using System;

namespace decimale_binario
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("inserisci un numero");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"il numero binario è {Convert.ToString(n, 2)}.");
        }
    }
}
