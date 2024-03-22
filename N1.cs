using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_N1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa, usando o comando SWITCH, que leia um número entre 0 e 4 e imprima
o valor lido por extenso (ex: “Quatro”), se o número estiver fora dessa faixa o programa deve imprimir
“Valor inválido”*/
            int n;
            Console.WriteLine("Escreva um numero qualquer");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                case 4:
                    Console.WriteLine("Quatro");
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }
            Console.ReadLine();
        }
    }
}
