using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_Interativa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            while (true)
            {
                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    result = num * i;
                    Console.WriteLine($"{num} x {i} = {result}");
                }
                Console.Write("Deseja ver outra tabuada? (s/n): ");
                string resposta = Console.ReadLine().ToLower();

                if (resposta == "n" || resposta != "s")
                {  
                     Console.WriteLine("Programa encerrado.");
                    break;
                }      
                
            }
           

        }
    }
}
