using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex13ParImpar
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            Console.Clear();
            if (numero %2 == 0)
            {
                Console.WriteLine($"O {numero} é par");
            }
            else
            {
                Console.WriteLine($"O {numero} é ímpar");
            }
        } 
    }
}
