using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio8
    {
        static void Main1(String[] args)
        {
            double raio, altura, volume;
            Console.WriteLine("VOLUME DE UMA LATA DE OLEO");
            Console.WriteLine();
            Console.Write("Informe o raio da lata: ");
            raio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a altura da lata: ");
            altura = Convert.ToDouble(Console.ReadLine());
            volume = ((3.14159 * raio) - (2 * altura));
            Console.WriteLine();
            Console.WriteLine("Volume da lata de oleo: {0}", volume);
            Console.ReadKey();
        }
    }
}
