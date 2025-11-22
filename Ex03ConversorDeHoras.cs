using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex03ConversorDeHoras
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite número de horas:");
            int valorHora = int.Parse(Console.ReadLine());

            int valorEmMinutos = valorHora * 60;
            int valorEmSegundos = valorHora * 3600;

            Console.WriteLine($"\n{valorHora} hora(s) em minutos é {valorEmMinutos}");
            Console.WriteLine($"{valorHora} hora(s) em segundos é {valorEmSegundos}");

        }
    }
}
