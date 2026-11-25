using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___FechamentoDeCaixa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vendas = new double[] { 50, 40, 30, 100, 101 };
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
            Console.WriteLine($"O faturamento total do dia: {faturamentoTotal}");
            Console.WriteLine($"A quantidade de vendas acima de R$ 100.00 : {vendasAltas}");
        }
    }
}
