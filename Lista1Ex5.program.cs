using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            Console.WriteLine("Realizando média aritmética:");
            Console.Write("Digite o primeiro valor:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor:");
            c = double.Parse(Console.ReadLine());
            Console.Write("Digite o quarto valor:");
            d = double.Parse(Console.ReadLine());

            e = (a + b + c + d) / 4;
            Console.WriteLine($"A Média Aritmética (dos valores {a},{b},{c} e {d}) é {e}.");

        }
    }
}
