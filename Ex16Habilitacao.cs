using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex16Habilitacao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano atual: ");
            int anoAtual = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o seu ano de nascimento");
            int anoNascimento = Convert.ToInt16(Console.ReadLine());

            int idade = anoAtual - anoNascimento;

            Console.Clear();
            if (idade > 17)
            {
                Console.WriteLine($"Você tem {idade}. Pode tirar a CNH:");
            }
            else 
            {
                Console.WriteLine($"Você tem {idade}. Não pode tirar a CNH:");
            }
        }
    }
}