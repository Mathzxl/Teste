using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_N3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia n números inteiros e verifique e imprima se eles são divisíveis,
de maneira independente, por 2, por 3, por 5 e por 6. Caso algum número não seja divisível por
nenhum desses números mostre a mensagem "Número não é divisível pelos valores". Apresente
também ao final a quantidade de números divisíveis por 2, por 3, por 5 e por 6. O programa deve
finalizar quando o usuário digitar o valor 0.
Exemplo:
12: divisível por 2,3,6
7: Número não é divisível pelos valores
0
Quantidade de números divisíveis por 2: 1
Quantidade de números divisíveis por 3: 1
Quantidade de números divisíveis por 5: 0
Quantidade de números divisíveis por 6: 1*/
            double n = 1;
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0;
            Console.WriteLine("De um valor qualquer. Caso queira para digite 0");
            while(n != 0)
            {
                n = double.Parse(Console.ReadLine());
                
                if (n % 2 == 0)
                {
                    c1++;
                } 
                if (n % 3 == 0)
                {
                    c2++;
                }
                if(n % 5 == 0)
                {
                    c3++;
                }
                if(n % 6 == 0)
                {
                    c4++;
                }
                if(n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 6 != 0){
                    Console.WriteLine("O número não é divisivel por 2,3,5,6");
                }
            }
            Console.WriteLine("Quantidade de números divisíveis por 2: " + c1);
            Console.WriteLine("Quantidade de números divisíveis por 3: " + c2);
            Console.WriteLine("Quantidade de números divisíveis por 5: " + c3);
            Console.WriteLine("Quantidade de números divisíveis por 6: " + c4);
            Console.ReadLine();
        }
    }
}
