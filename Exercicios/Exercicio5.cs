using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio5
    {
        static void Main1(String[] args)
        {
            double raio, volume;
            Console.WriteLine("VOLUME DE UMA ESFERA");
            Console.WriteLine();
            Console.Write("Informe o raio da esfera: ");
            raio = Convert.ToDouble(Console.ReadLine());
            volume = (4 * 3.1416 * Math.Pow(raio, 3) / 3);
            Console.WriteLine();
            Console.WriteLine("Volume da esfera: {0}", volume);
            Console.ReadKey();
        }
    }
}
