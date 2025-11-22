using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex37Hospedaria
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========| Hospedaria |==========");
            Console.WriteLine("Digite o número de dias que ficou hospedado:");
            int numeroDias = Convert.ToInt32(Console.ReadLine());

            double valorDia = 0;

            if (numeroDias < 5)
            {
                valorDia = 150.00;
            }
            else if (numeroDias > 4 && numeroDias < 11)
            {
                valorDia = 120.00;
            }
            else if (numeroDias > 10) 
            {
                valorDia = 100.00;
            }

            double valorTotal = numeroDias * valorDia;

            Console.WriteLine($"-------------------------------------\n" +
                                $"  Você deve pagar {valorTotal:C2}" +
                                $"\n-------------------------------------");
        }
    }
}