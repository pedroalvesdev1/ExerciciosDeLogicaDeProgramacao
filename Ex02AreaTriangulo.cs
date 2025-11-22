using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex02AreaTriangulo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Área do Triângulo\n");

            Console.WriteLine("Digite o valor da base do triângulo:");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do triângulo:");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            Console.WriteLine($"\nA área do triângulo é {areaTriangulo}.");
        }
    }
}
