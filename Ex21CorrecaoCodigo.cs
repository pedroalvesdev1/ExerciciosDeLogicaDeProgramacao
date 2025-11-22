using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex21CorrecaoCodigo
    {
        public static void Main(string[] args)
        {
            /*
                inicio
                ler base
                ler altura
                area = base + altura
                escrever area
                fim
            */

            Console.WriteLine("Digite o valor da base: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            double area = baseRetangulo * alturaRetangulo;

            Console.WriteLine($"A área é {area}.");
        }
    }
}