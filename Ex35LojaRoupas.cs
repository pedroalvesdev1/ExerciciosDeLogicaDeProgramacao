using System;

namespace ExerciciosGemini
{
    internal class Ex35LojaRoupas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===== Loja roupas =====");

            Console.WriteLine("Digite quantas camisetas deseja: ");
            int quantCamiseta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite quantas calças deseja: ");
            int quantCalca = Convert.ToInt32(Console.ReadLine());

            double precoCamisa = 50.0;
            double precoCalca = 90.0;

            int totalItens = quantCalca + quantCamiseta;
            double total = (quantCalca * precoCalca) + (quantCamiseta * precoCamisa);

            if (totalItens > 5)
            {
                total -= total * 0.15; // 15%
            }
            else if (totalItens > 3)
            {
                total -= total * 0.10; // 10%
            }

            Console.WriteLine($"Total a pagar: {total:C2}");
        }
    }
}
