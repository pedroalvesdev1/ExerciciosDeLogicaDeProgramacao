using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex23ControleEstoque
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade em estoque: ");
            int quantEstoque = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade a ser vendida: ");
            int quantVendida = Convert.ToInt32(Console.ReadLine());

            if (quantEstoque >= quantVendida)
            {
                Console.WriteLine("Pedido Liberado.");
            }
            else 
            { 
                Console.WriteLine("Estoque Insuficiente.");
            }
        }
    }
}
