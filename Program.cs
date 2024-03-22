using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIsta_3_N1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia um número correspondente a um determinado ano e em seguida informe se
este ano é ou não é bissexto. Um ano é bissexto se ele for divisível por 400 OU se ele for divisível por 4 e
não por 100.
Exemplos de anos bissextos: 2000, 2004, 2040*/
            Console.WriteLine("Digite um ano:");
            int ano = int.Parse(Console.ReadLine());
            string mensagem = ((ano % 400 == 0) || ((ano % 4 == 0) && (ano % 100 != 0))) ? "O ano é bissexto." : "O ano não é bissexto.";
            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
    }
}
