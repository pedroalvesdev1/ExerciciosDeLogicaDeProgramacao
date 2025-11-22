using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex40Emprestimo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do emprestimo: ");
            double valorEmprestimo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite em quantas parcelas você vai pagar: ");
            double  quantParcelas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu salário mensal: ");
            double salarioMensal = Convert.ToDouble(Console.ReadLine());

            double valorParcelas = valorEmprestimo / quantParcelas;

            double parcela = salarioMensal * 0.30;

            double riscoBaixo = salarioMensal * 0.10;

            double riscoMedio = salarioMensal * 0.20;

            if (valorParcelas > parcela)
            {
                Console.WriteLine("Empréstimo Negado: Parcela muito alta.");
            }
            else
            {
                if (valorParcelas <= riscoBaixo)
                {
                    Console.WriteLine("Empréstimo Aprovado - Risco Baixo (Cliente VIP).");
                }
                else if (valorParcelas >= riscoBaixo && valorParcelas <= riscoMedio)
                {
                    Console.WriteLine("Empréstimo Aprovado - Risco Médio.");
                }
                else if (valorParcelas > riscoMedio)
                {
                    Console.WriteLine("Empréstimo Aprovado - Risco Alto.");
                }
            }
        }
    }
}