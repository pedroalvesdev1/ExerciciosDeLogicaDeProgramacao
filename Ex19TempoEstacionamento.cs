using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex19TempoEstacionamento
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora que você entrou em horas:");
            int horaEntrada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a hora da saída em horas: ");
            int horaSaida = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            if (horaEntrada > horaSaida)
            {
                Console.WriteLine("Erro: A hora de entrada não pode ser depois da saída!.");
            }
            else 
            {
                int totalHora = horaSaida - horaEntrada;
                Console.WriteLine($"Você ficou durante {totalHora} hora(s)");
            }
        } 
    }
}
