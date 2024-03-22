using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_N4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa para imprimir os números ímpares entre 3 até 999
            int n = 1;
            while (n <= 999)
            {
                Console.WriteLine(n++);
                n = n + 1;
            }
            Console.ReadLine();
        }
    }
}
