using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex08TemperaturaKelvin
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em graus Celsius(°C):");
            double grausCelsius = Convert.ToDouble(Console.ReadLine());

            double kelvin = grausCelsius + 273.15;

            Console.WriteLine($"A temperatura em Kelvin é {kelvin}K");
        }
    }
}
