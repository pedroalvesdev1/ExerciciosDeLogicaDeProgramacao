using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex17MenorValor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° valor: ");
            int numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o 2° valor: ");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            int menor = 0;

            if (numero1 < numero2)
            {
                menor = numero1;
            }
            else 
            {
                menor = numero2;
            }

            Console.WriteLine($"O menor número é {menor}");
        }
    }
}