using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex25PNZ
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero > 0)
            {
                Console.WriteLine("O número é positivo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("O número é igual à zero");
            }
            else
            {
                Console.WriteLine("O número é negativo");
            }
        }
    }
}
