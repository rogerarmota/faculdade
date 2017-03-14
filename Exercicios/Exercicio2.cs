using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio2
    {
        static void Main1(String[] args)
        {
            double fahrenheit, convertido;
            Console.WriteLine("CONVERSÃO DE TEMPERATURA");
            Console.WriteLine();
            Console.Write("Informe a temperatura em Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            convertido = ((fahrenheit - 32) * 5 / 9);
            Console.WriteLine();
            Console.WriteLine("Temperatura em Celsius: {0}", convertido);
            Console.ReadKey();
        }
    }
}
