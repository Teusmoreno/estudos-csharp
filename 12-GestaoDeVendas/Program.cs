using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_GestaoDeVendas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> vendas = new List<double>();      

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE GESTÃO DE VENDAS ===");
                Console.WriteLine("1 - Registrar venda");
                Console.WriteLine("2 - Listar todas as vendas");
                Console.WriteLine("3 - Relatório de fechamento");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                int opcao = int.Parse(Console.ReadLine());
                
                if (opcao == 1)
                {
                    Console.Write("Digite o Valor da venda: R$ ");
                    double ValorDevendas = double.Parse(Console.ReadLine());
                    if (ValorDevendas <= 0)
                    {
                        Console.WriteLine("\nValor inválido! a venda precisa ser maior que zero.");
                    }
                    else
                    {
                        Console.WriteLine("Venda registrada com sucesso!");
                        vendas.Add(ValorDevendas);
                    }

                }
                else if (opcao == 2)
                {
                    Console.WriteLine("--- VENDAS REGISTRADAS HOJE ---");
                    if (vendas.Count == 0)
                    {
                        Console.WriteLine("\nNão houve vendas ainda...");
                    }

                    foreach (double venda in vendas)

                    {
                        Console.WriteLine($"- R$: {venda}");
                    }
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("--- RELATÓRIO DE FECHAMENTO ---");
                    if (vendas.Count == 0)
                    {
                        Console.WriteLine("Ainda não há vendas para montar o relatório...");
                    }
                    else
                    {
                        double faturamentoTotal = 0;
                        int vendasAltas = 0;

                        foreach (double venda in vendas)
                        {
                            faturamentoTotal += venda;
                            if (venda > 100)
                            {
                                vendasAltas++;
                            }
                        }
                        double ticketMedio = faturamentoTotal / vendas.Count();

                        Console.WriteLine($"Quantidade de vendas: {vendas.Count()}");
                        Console.WriteLine($"Faturamento total: R$ {faturamentoTotal}");
                        Console.WriteLine($"Vendas acima de R$ 100,00: {vendasAltas}");
                        Console.WriteLine($"Ticket médio: {ticketMedio}");

                    }

                    if (opcao == 4)
                    {
                        break;
                    }
                }
                Console.WriteLine("\nPressione algo para voltar ao menu...");
                Console.ReadKey();
            }
            
        }
    }
}
