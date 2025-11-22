using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex30JokenPo
    {
        public static void Main(string[] args)
        {
            string[] opcao = { "[1] Pedra", "[2] Papel", "[3] Tesoura" };
            int contador = 0;

            Console.WriteLine("Jogadro 1 deigite sua opção:\n");
            while (contador < 3)
            {
                Console.WriteLine(opcao[contador]);
                contador++;
            }
            int opcaoJogador1 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            contador = 0;

            Console.WriteLine("Jogadro 2 deigite sua opção:\n");
            while (contador < 3)
            {
                Console.WriteLine(opcao[contador]);
                contador++;
            }
            int opcaoJogador2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (opcaoJogador1 == opcaoJogador2)
            {
                Console.WriteLine("Empate");
            }

            if (opcaoJogador1 == 1 && opcaoJogador2 == 2)
            {
                Console.WriteLine("Jogador 2 Venceu");
            }
            else if (opcaoJogador1 == 2 && opcaoJogador2 == 3)
            {
                Console.WriteLine("Jogador 2 Venceu");
            }
            else if (opcaoJogador1 == 3 && opcaoJogador2 == 1)
            {
                Console.WriteLine("Jogador 2 Venceu");
            }

            if (opcaoJogador2 == 1 && opcaoJogador1 == 2)
            {
                Console.WriteLine("Jogador 1 Venceu");
            }
            else if (opcaoJogador2 == 2 && opcaoJogador1 == 3)
            {
                Console.WriteLine("Jogador 1 Venceu");
            }
            else if (opcaoJogador2 == 3 && opcaoJogador1 == 1)
            {
                Console.WriteLine("Jogador 1 Venceu");
            }

            Console.WriteLine($"Opção jogador 1:{opcao[opcaoJogador1 - 1]}");
            Console.WriteLine($"Opção jogador 2:{opcao[opcaoJogador2 - 1]}");
        }
    }
}