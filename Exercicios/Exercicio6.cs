using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio6
    {
        static void Main1(String[] args)
        {
            double celsius, fahrenheit;
            Console.WriteLine("CONVERSÃO DE TEMPERATURA");
            Console.WriteLine();
            Console.Write("Informe a temperatura em Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (((9 * celsius) + 160) / 5);
            Console.WriteLine();
            Console.WriteLine("Temperatura em Fahrenheit: {0}", fahrenheit);
            Console.ReadKey();
        }
    }
}
