using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex28OrdemCrescente
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° valor: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2° valor: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 3° valor: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            int menor = numero1;
            int meio = numero1;
            int maior = numero1;
            
            
            if (numero1 < numero2 && numero1 < numero3)
            {
                menor = numero1;
            }

            if (numero2 < numero3 && numero2 < numero1)
            {
                menor = numero2;
            }

            if (numero3 < numero2 && numero3 < numero1)
            {
                menor = numero3;
            }

            if (numero1 > numero2 && numero1 > numero3)
            {
                maior = numero1;
            }

            if (numero2 > numero3 && numero2 > numero1)
            {
                maior = numero2;
            }

            if (numero3 > numero2 && numero3 > numero1)
            {
                maior = numero3;
            }

            /*
                if (numero1 > menor && numero1 < maior)
                {
                    meio = numero1;
                }

                if (numero2 > menor && numero2 < maior)
                {
                    meio = numero2;
                }

                if (numero3 > menor && numero3 < maior)
                {
                    meio = numero3;
                }
            */

            int soma = numero1 + numero2 + numero3;

            meio = soma - maior - menor;

            Console.WriteLine($"{menor}, {meio}, {maior}");

        }
    }
}