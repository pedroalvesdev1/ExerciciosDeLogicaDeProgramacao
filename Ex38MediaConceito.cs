using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex38MediaConceito
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da média final: ");
            double mediaFinal = Convert.ToDouble(Console.ReadLine());
            string conceito = "";

            if (mediaFinal >= 9)
            {
                conceito = "A";
            }
            else if(mediaFinal >= 7.5)
            {
                conceito = "B";
            }
            else if (mediaFinal >= 6)
            {
                conceito = "C";
            }
            else 
            {
                conceito = "D";
            }

            Console.WriteLine(conceito);
        }
    }
}