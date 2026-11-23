using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine($"{num} x {i} = {result}");
            }
        }
    }
}
