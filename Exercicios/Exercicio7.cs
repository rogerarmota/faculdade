using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio7
    {
        static void Main1(String[] args)
        {
            double salarioTotal, salarioFixo, totalVendas, percentualGanho;
            Console.WriteLine("Salario do Vendedor");
            Console.WriteLine();
            Console.Write("Informe o salario: ");
            salarioFixo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o total de vendas: ");
            totalVendas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o percentual de vendas: ");
            percentualGanho = Convert.ToDouble(Console.ReadLine());
            salarioTotal = (salarioFixo + (totalVendas * (percentualGanho / 100)));
            Console.WriteLine();
            Console.WriteLine("Salario do vendedor: {0}", salarioTotal);
            Console.ReadKey();
        }
    }
}
