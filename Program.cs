using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09Jogo21
{
    class Program
    {
        static void Main(string[] args)
        {

            int pontos = 0;

            Console.WriteLine("Bem-vindo ao Jogo do 21");
            Console.WriteLine("Faça 21 pontos para vencer");

            while (true)
            {
                Console.WriteLine($"Você tem {pontos}");

                Console.WriteLine("Digite 1 para continuar jogando ou 2 para encerrar as apostas:");
                int opcao = int.Parse(Console.ReadLine());

                if ( opcao == 2 )
                {
                    Console.WriteLine("Fim de jogo");
                    break;
                }

                Random sorteador = new Random();
                int numero = sorteador.Next(1, 11);
                Console.WriteLine($"Você fez {numero} pontos!");

                pontos += numero;

                if (pontos >= 21)
                {
                    Console.WriteLine("Fim de jogo!");
                    break;

                   
                }


  
              
            }
            Console.ReadKey();

        }
    }
}
