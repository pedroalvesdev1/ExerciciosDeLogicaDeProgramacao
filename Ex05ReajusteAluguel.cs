using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex05ReajusteAluguel
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor atual do seu aluguel: ");
            double valorAtualAluguel = Convert.ToDouble(Console.ReadLine());

            double novoAluguel = valorAtualAluguel + ((12.0 / 100) * valorAtualAluguel);

            Console.WriteLine($"\nO valor do atualizado do aluguel é {novoAluguel.ToString("C2")}");
        }
    }
}
