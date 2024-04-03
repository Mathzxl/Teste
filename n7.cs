using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            double soma = 0;
            Console.WriteLine("Digite um valor inteiro positivo:");
            n = int.Parse(Console.ReadLine());
            while (i <= n)
            {
                soma += (double)1 / (i * (i + 1));
                i++;
            }
            Console.WriteLine("O valor de S é: " + soma);
            Console.ReadLine();
        }
    }
}
