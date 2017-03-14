using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio10
    {
        static void Main1(String[] args)
        {
            double N1, N2, mediaP;
            Console.WriteLine("MEDIA PONDERADA");
            Console.WriteLine();
            Console.Write("Informe a 1ª nota: ");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a 2ª nota: ");
            N2 = Convert.ToDouble(Console.ReadLine());
            mediaP = ((N1 * 1 + N2 * 2) / (1 + 2));
            Console.WriteLine();
            Console.WriteLine("Media ponderada: {0}", mediaP);
            Console.ReadKey();
        }
    }
}
