using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex29Triangulo
    {
        public static void Main(string[] args)
        {

            Console.WriteLine($"Digite o 1° número: ");
            double ladoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Digite o 2° número: ");
            double ladoB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Digite o 3° número: ");
            double ladoC = Convert.ToDouble(Console.ReadLine());

            if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if(ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é triângulo");
            }
        }
    }
}