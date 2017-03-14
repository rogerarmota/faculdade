using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio1
    {
        static void Main1(String[] args)
        {
            double comprimento, largura, altura, volume;
            Console.WriteLine("VOLUME DA CAIXA");
            Console.WriteLine();
            Console.Write("Informe o comprimento da caixa: ");
            comprimento = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a largura da caixa: ");
            largura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a altura da caixa: ");
            altura = Convert.ToDouble(Console.ReadLine());
            volume = comprimento * largura * altura;
            Console.WriteLine();
            Console.WriteLine("Volume da caixa: {0} litros", volume);
            Console.ReadKey();
        }
    }
}
