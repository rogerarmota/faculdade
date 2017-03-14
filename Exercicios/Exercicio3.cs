using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio3
    {
        static void Main1(String[] args)
        {
            double areab, raio, volume, altura;
            Console.WriteLine("VOLUME DE UM CILINDRO");
            Console.WriteLine();
            Console.Write("Informe o raio do cilindro: ");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a altura do cilindro: ");
            altura = Convert.ToDouble(Console.ReadLine());
            areab = (3.1416 * raio * raio);
            volume = (areab * altura);
            Console.WriteLine();
            Console.WriteLine("Volume do cilindro: {0}", volume);
            Console.ReadKey();
        }
    }
}
