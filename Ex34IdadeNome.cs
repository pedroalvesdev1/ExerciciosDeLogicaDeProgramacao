using System;
namespace ExerciciosGemini
{
    internal class Ex34IdadeNome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da pessoa 1:");
            string nomePessoa1 = Console.ReadLine();
            Console.WriteLine("Digite o idade da pessoa 1:");
            int idadePessoa1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o nome da pessoa 2:");
            string nomePessoa2 = Console.ReadLine();
            Console.WriteLine("Digite o idade da pessoa 2:");
            int idadePessoa2 = Convert.ToInt16(Console.ReadLine());

            if (idadePessoa1 > idadePessoa2)
            {
                Console.WriteLine($"A pessoa mais velha é {nomePessoa1} com {idadePessoa1} anos");
                Console.WriteLine($"A pessoa nova velha é {nomePessoa2} com {idadePessoa2} anos");
            }
            else
            {
                Console.WriteLine($"A pessoa mais velha é {nomePessoa2} com {idadePessoa2} anos");
                Console.WriteLine($"A pessoa nova velha é {nomePessoa1} com {idadePessoa1} anos");
            }
        }
    }
}