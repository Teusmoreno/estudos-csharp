using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CadastroDeProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string>();   

            while(true)
            {
                Console.Clear();
                Console.WriteLine("\nAperte 1 se deseja adicionar um novo produto: ");
                Console.WriteLine("\nAperte 2 para Remover um produto: ");
                Console.WriteLine("\nAperte 3 para mostrar o estoque: ");
                Console.WriteLine("\nAperta 4 para sair.\n");

                int opcao= int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("Digite o nome do produto que deseja adicionar: ");
                    string novoProduto = Console.ReadLine();     

                   if (produtos.Contains(novoProduto))
                    {
                        Console.WriteLine("Esse produto ja existe na lista! ");
                    }
                   else
                    {
                        produtos.Add(novoProduto);
                        Console.WriteLine("Produto adicionado com sucesso!");
                    }
           
                }
                else if (opcao == 2)
                {
                    Console.Write("Digite o nome do produto que deseja remover: ");
                    string removerProduto = Console.ReadLine();
                    
                    if(produtos.Remove(removerProduto))
                    {
                        Console.WriteLine("Produto removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Produto não encontrado!");
                    }

                }
                else if (opcao == 3)
                {
                    foreach (string produto in produtos)
                    {
                        
                        Console.WriteLine($"{produto}");
                    }
                }
                else if (opcao == 4)
                {
                    break;
                }
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                
            }
        }
    }
}
