using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolva um algoritmo que imprima os n primeiros elementos da sequência de Fibonacci.
Ex.: Se n = 10, imprimir os 10 primeiros números da sequência de Fibonacci (Obs: Pesquise na
internet como a sequência de Fibonacci é calculada). */
            int n;
            Console.WriteLine("De um valor qualquer");
            n = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 2;
            int contador = 0;
            int c = 0;
            Console.WriteLine("Os primeiro " + n + " números da sequência de Fibonacci são:");
            while (contador < n)
            {
                Console.WriteLine(c);
                c = a + b;
                a = b;
                b = c;
                contador++;
            }
            Console.ReadLine();
        }
    }
}
