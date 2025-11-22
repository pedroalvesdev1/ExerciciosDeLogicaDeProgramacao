using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex12MaiorIgualMenorZero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            Console.Clear();
            if(numero > 0)
            {
                Console.WriteLine($"O {numero} é maior que zero.");
            }
            else if (numero == 0)
            {
                Console.WriteLine($"O {numero} é igual que zero.");
            }
            else
            {
                Console.WriteLine($"O {numero} é menor que zero.");
            }
        }
    }
}