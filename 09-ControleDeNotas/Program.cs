using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _09_ControleDeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[5];
            double soma = 0;
            int aprovados = 0;
            int reprovados = 0;
            double media = 0;
            
            for (int i =0; i< notas.Length; i++ )
            {
                Console.Write($"Digite a {i + 1}º nota: ");
                notas[i] = double.Parse(Console.ReadLine());

                
            }
            foreach (double nota in notas)
            {
                soma += nota;

                if (nota >= 7)
                {
                    aprovados++;
                }

                else
                {
                    reprovados++;
                }
            }
                media = soma / notas.Length;

                Console.WriteLine("\n --- Relatório da Turma -- ");
                Console.WriteLine($"Média geral: {media}");
                Console.WriteLine($"Total de aprovados (>= 7): {aprovados}");
                Console.WriteLine($"Total de reprovados(< 7:) {reprovados}");
            
        }
    }
}
