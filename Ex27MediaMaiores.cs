using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex27MediaMaiores
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1° valor: ");
            double numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 2° valor: ");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 3° valor: ");
            double numero3 = Convert.ToInt32(Console.ReadLine());

            double menor = numero1;

            if (numero2 < menor)
            {
                menor = numero2;
            }

            if (numero3 < menor) 
            {
                menor = numero3;
            }

            double media = ((numero1 + numero2 + numero3) - menor) / 2;
            Console.WriteLine(media.ToString("F2"));
        }
    }
}