using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ListaDeCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] compras = new string[4];




            for (int i = 0; i< compras.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º item da lista: ");
                compras[i] = Console.ReadLine();

            }

            Console.WriteLine("\n--- Sua Lista de Compras ---");

            foreach (string item in compras)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
