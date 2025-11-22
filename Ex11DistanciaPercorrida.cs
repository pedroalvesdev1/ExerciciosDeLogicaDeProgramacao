using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex11DistanciaPercorrida
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a velocidade em km/h: ");
            int velocidadeVeiculo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a duraçõa da viagem em horas: ");
            int tempoViagem = Convert.ToInt32(Console.ReadLine());

            int distancia = velocidadeVeiculo * tempoViagem;

            Console.WriteLine($"A distância percorrida foi de {distancia}Km");

        }
    }
}