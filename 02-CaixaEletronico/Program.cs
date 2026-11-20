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

                // Bloco do depósito
                else if (opcao == 2)
                {
                    Console.WriteLine("Digite o valor a ser depositado : ");
                    deposito = double.Parse(Console.ReadLine());

                    if (deposito <= 0)
                    {
                        Console.WriteLine("Valor inválido para depósito!");
                        continue;
                    }
                    saldo += deposito;
                    Console.WriteLine($"Você depositou: {deposito}");

                }

                //Bloco do saque
                else if (opcao == 3)
                {
                    Console.WriteLine("Digite o valor a ser sacado: ");
                    sacar = double.Parse(Console.ReadLine());
                    if (sacar > saldo || sacar <= 0)
                    {
                        Console.WriteLine("Saldo insuficiente ou valor inválido!");
                        continue;
                    }
                    saldo -= sacar;
                    Console.WriteLine($"Você sacou: {sacar}");  
                }

                // Adicionado um novo else if so para sair do aplicativo
                else if (opcao == 4) 
                {
                    Console.WriteLine("Encerrando o caixa eletrônico...");
                    break;
                }

                // Bloco de erro para números que não estejam na lista de escolha
                else
                {
                    Console.WriteLine("Opção inválida, Escolha entre 1 e 4.");
                }
            }
        }
    }
}
