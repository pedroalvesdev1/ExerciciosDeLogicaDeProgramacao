using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex26MaiorNumero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° valor: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2° valor: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 3° valor: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            int maior = numero1;

            if (numero2 > numero1)
            {
                maior = numero2;

                if (numero2 > numero3)
                {
                    maior = numero2;
                }
            }

            if (numero3 > numero1)
            {
                maior = numero3;

                if (numero3 > numero2)
                {
                    maior = numero3;
                }
            }

            Console.Clear();
            Console.WriteLine($"O maior número digitado foi {maior}");

        }
    }
}