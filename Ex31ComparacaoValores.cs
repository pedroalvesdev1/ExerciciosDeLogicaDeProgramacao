using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex31ComparacaoValores
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° valor:");
            int numero1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o 2° valor:");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            if (numero1 == numero2) 
            {
                Console.WriteLine("\nNúmero iguais");
            }
            else if (numero1 > numero2)
            {
                Console.WriteLine("\nO primeiro número é maior");
            }
            else
            {
                Console.WriteLine("\nO segundo número é maior");
            }
        }
    }
}