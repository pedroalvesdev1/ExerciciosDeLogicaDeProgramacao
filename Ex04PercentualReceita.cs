using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex04PercentualReceita
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso da farinha em gramas(gr):");
            double pesoFarinha = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso dos ovos em gramas(gr):");
            double pesoOvos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso do leite em gramas(gr):");
            double pesoLeite = Convert.ToDouble(Console.ReadLine());

            double totalIngredientes = pesoFarinha + pesoOvos + pesoLeite;

            double percentualFarinha = (pesoFarinha * 100) / totalIngredientes;
            double percentualOvos= (pesoOvos * 100) / totalIngredientes;
            double percentualLeite= (pesoLeite * 100) / totalIngredientes;


            Console.WriteLine($"Percetual de farinha:{percentualFarinha.ToString("F2")}%\n" +
                $"Percetual de Ovos:{percentualOvos.ToString("F2")}%\n" +
                $"Percetual de farinha:{percentualLeite.ToString("F2")}%");
        }
    }
}
