using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorDeNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int pares = 0;
            int impares = 0;
            int maior = int.MinValue;

            for (int i = 1; i<= 5; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                int num = int.Parse(Console.ReadLine());

                soma += num;

             if (num % 2 == 0)
            {
                pares++;
                                 
            }
             else
                 {
                    impares++;
                }
             if (num > maior)
                {
                    maior = num;
                }

             

            }
              Console.WriteLine("\n ---Resultado Final---");
            Console.WriteLine($"Soma total: {soma}");
            Console.WriteLine($"Quantidade de pares: {pares}");
            Console.WriteLine($"Quantidade de ímpares : {impares}");
            Console.WriteLine($"Maior número digitado: {maior}");


        }
    }
}
