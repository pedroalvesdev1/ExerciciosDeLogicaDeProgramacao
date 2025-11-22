using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex01AntecessorSucessor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sucessor e Antecessor\n");
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int antecessor = numero - 1;
            int sucessor = numero + 1;

            Console.WriteLine($"O antecessor do número {numero} é {antecessor}");
            Console.WriteLine($"O sucessor do número {numero} é {sucessor}");
        }
    }
}
