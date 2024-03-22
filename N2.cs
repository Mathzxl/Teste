using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_N2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*screva um programa, usando o comando SWITCH, para mostrar o menu de opções de
conversão, a seguir leia a opção do usuário e os dados necessários para executar cada operação.
Calcule a operação selecionada pelo usuário e imprima na tela o resultado. Caso o usuário
selecione uma opção inválida, o programa deve imprimir “Opção Inválida”(Obs: Pesquise na internet
como fazer as conversões).
Conversões:
1. Converter de centímetros para metros
2. Converter de metros para centímetros
3. Converter de milímetros para metros
4. Converter de metros para milímetros*/
            double n, conversão;
            int opçoes;
            Console.WriteLine("Escolha uma das seguintes opções:\n\n(1) Centímetros para Metros\n\n(2) Metros para Centímetros\n\n(3) Milímetros para Metros\n\n(4) Metros para Milímetros");
            opçoes = int.Parse(Console.ReadLine());
            Console.WriteLine("Dê o valor desejado para a conversão");
            n = double.Parse(Console.ReadLine());
            switch (opçoes)
            {
                case 1:
                    conversão = n / 100;
                    Console.WriteLine("Convertendo" + n + "para metros ficará: " + conversão);
                    break;
                case 2:
                    conversão = n * 100;
                    Console.WriteLine("Convertendo" + n + "para centímetros ficará: " + conversão);
                    break;
                case 3:
                    conversão = n / 1000;
                    Console.WriteLine("Convertendo" + n + "para metros ficará: " + conversão);
                    break;
                case 4:
                    conversão = n * 1000;
                    Console.WriteLine("Convertendo" + n + "para milímetros ficará: " + conversão);
                    break;
                default:
                    Console.WriteLine("Não foi possivel fazer a conversão opção invalida!!\nSelecione outra opção");
                    break;
            }
            Console.ReadLine();
        }
    }
}
