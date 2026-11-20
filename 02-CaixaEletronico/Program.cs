using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CaixaEletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 1000.00;
            double deposito = 0.00;
            double sacar = -0.00;

            while(true)
            {
                Console.WriteLine("Seja bem-vindo ao caixa eletrônico!");
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("\t1- Ver Saldo");
                Console.WriteLine("\t2- Depositar");
                Console.WriteLine("\t3- Sacar");
                Console.WriteLine("\t4- Sair");
                int opcao = int.Parse (Console.ReadLine());

                
                if (opcao == 1)
                {
                 
                    Console.WriteLine($"Seu Saldo atual é de : {saldo}");
                    continue;
                }
                else if (opcao == 2)
                {
                        Console.WriteLine("Digite o valor a ser depositado : ");
                    deposito = double.Parse(Console.ReadLine());
                     Console.WriteLine($"Você depositou: {deposito}");
                    saldo += deposito;
                    
                    continue;
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Digite o valor a ser sacado: ");
                    sacar = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Você sacou: {sacar}");
                    saldo -= sacar;
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
