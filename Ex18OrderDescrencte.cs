using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex18OrderDescrencte
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2° número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int menor = 0; 
            int maior = 0;

            if (numero1 < numero2)
            {
                menor = numero1;
                maior = numero2;
            }
            else 
            {
                menor = numero2;
                maior = numero1;
            }

            Console.WriteLine($"{menor}, {maior}");
        }
    }
}
