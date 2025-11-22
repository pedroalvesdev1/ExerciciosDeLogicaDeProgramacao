using System;

namespace ExerciciosGemini
{
    internal class Ex32TesteMesa
    {
        public static void Main(string[] args)
        {
            /*
                Teste de Mesa (Seleção): Faça um teste de mesa e complete o quadro para o algoritmo a seguir:
                    ```
                    inicio
                    ler a, b
                    x = a + b
                    y = a * b
                    se x > 10 então
                      se y > 50 então
                        resp = 'A'
                      senão
                        resp = 'B'
                      fim_se
                    senão
                      resp = 'C'
                    fim_se
                    escrever x, y, resp
                    fim
                    ```

                | Variáveis | | | |
                | :--- | :---: | :---: |  |
                | a  | b |  x | y  | resp |
                | 5  | 6 | 11 | 30 | B    |
                | 2  | 3 |  5 | 6  | C    |
                | 10 | 1 | 11 | 10 | B    |
                | 7  | 7 | 14 | 49 | B    |
                | :--- | :---: | :---: |  |

             
             */

            Console.WriteLine("Digite o valor de A: ");
            int valorA = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            int valorB = Convert.ToInt16(Console.ReadLine());

            int x = valorA + valorB; 
            int y = valorA * valorB;
            string resp = "";

            if (x>10)
            {
                if (y > 50)
                {
                    resp = "A";
                }
                else
                {
                    resp = "B";
                }
            }
            else
            {
                resp = "C";
            }

            Console.WriteLine($"Valor de X: {x} \nValor de Y: {y} \nResposta:{resp}");

        }
    }
}