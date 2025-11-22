using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex20BonusVendas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite quanto faturou em vendas: ");
            double vendas = Convert.ToSingle(Console.ReadLine());

            double salario = 2000;

            Console.Clear();

            if (vendas > 49999.99)
            {
                double difrenca = vendas - 50000;
                double bonus = 0.05 * difrenca;
                salario = salario + bonus;
                Console.WriteLine($"O seu bonûs é {bonus.ToString("C2")}");
            }

            Console.WriteLine($"O seu salário é {salario.ToString("C2")}");
        }
    }
}