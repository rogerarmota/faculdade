using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio9
    {
        static void Main1(String[] args)
        {
            double N1, N2, N3, N4, mediaH;
            Console.WriteLine("MEDIA HARMONICA");
            Console.WriteLine();
            Console.Write("Informe a 1ª nota: ");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a 2ª nota: ");
            N2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a 3ª nota: ");
            N3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a 4ª nota: ");
            N4 = Convert.ToDouble(Console.ReadLine());
            mediaH = (4 / ((1 / N1) + (1 / N2) + (1 / N3) + (1 / N4)));
            Console.WriteLine();
            Console.WriteLine("Media Harmonica: {0}", mediaH);
            Console.ReadKey();
        }
    }
}
