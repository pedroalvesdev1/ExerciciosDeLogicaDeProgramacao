using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex39Concurso
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota da prova objetiva");
            double notaObjetiva = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota da prova de títulos");
            double notaTitulo = Convert.ToDouble(Console.ReadLine());

            if (notaObjetiva >= 60 && notaTitulo >= 10 || notaObjetiva >= 90)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
