using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex36Login
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua senha:");
            int senha = Convert.ToInt32(Console.ReadLine());

            const int senhaCorreta = 4321;
            const string palavraPasseCorreta = "Marcha";

            if (senha == senhaCorreta)
            {
                Console.WriteLine("Digite a palavra-passe:");
                string palavraPasse = Console.ReadLine();

                if (palavraPasse == palavraPasseCorreta)
                {
                    Console.Clear();
                    Console.WriteLine("------| Acesso Liberado |------");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Palavra-chave incorreta");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("PIN inválido");
            }
        }
    }
}