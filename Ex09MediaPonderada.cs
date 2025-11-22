using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex09MediaPonderada
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a 1° nota: ");
            float nota1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a 2° nota: ");
            float nota2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a 3° nota: ");
            float nota3 = Convert.ToSingle(Console.ReadLine());

            float media = ((nota1 * 3) + (nota2 * 3) + (nota3 * 4)) / (3 + 3 + 4);

            Console.WriteLine($"A média ponderada das notas foi {media.ToString("F2")}.");
        }
    }
}
