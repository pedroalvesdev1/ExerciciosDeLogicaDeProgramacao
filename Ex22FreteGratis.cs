using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex22FreteGratis
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor total da compra:");
            double valorCompra = Convert.ToDouble(Console.ReadLine());

            if (valorCompra > 200)
            {
                Console.WriteLine("Parabéns, você ganhou frete grátis");
            }
            else
            {
                valorCompra += 25;
                Console.WriteLine($"Valor da total compra junto a taxa de frete de R$25,00 é de {valorCompra.ToString("C2")}");
            }
        }
    }
}
