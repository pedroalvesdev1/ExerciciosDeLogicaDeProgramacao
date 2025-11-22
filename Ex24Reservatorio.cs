using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex24Reservatorio
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor atual de áqua em metros(m): ");
            double nivelAquaAtual = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o nível de áqua em alerta: ");
            double nivelAquaAlerta = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            if (nivelAquaAtual >= nivelAquaAlerta)
            {
                Console.WriteLine("Emitir Alerta de Risco");
            }
            else
            {
                Console.WriteLine("Nível Operacional Normal");
            }
        }
    }
}