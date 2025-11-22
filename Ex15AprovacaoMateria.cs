using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex15AprovacaoMateria
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da 1° nota: ");
            float nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor da 2° nota: ");
            float nota2 = Convert.ToSingle(Console.ReadLine());

            float media = (nota1 + nota2) / 2;

            Console.Clear();
            if (media > 7)
            {
                Console.WriteLine($"Você foi aprovado com {media.ToString("F2")}.");
            }
            else
            {
                Console.WriteLine($"Você foi reprovado com nota {media.ToString("F2")}");
            }
        }
    }
}
