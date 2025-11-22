using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex14ValorIngresso
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===== Bem-Vindo ao cinema =====");

            Console.WriteLine("Você é estudante? [S]Sim [N]Não.");
            string resposta = Console.ReadLine();

            if (resposta.ToUpper() == "S")
            {
                Console.WriteLine("Você recebe R$10,00 de desconto. \n");  
            }
            else
            {
                Console.WriteLine("Você deve pagr R$20,00");
            }
        }
    }
}
