using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int portaAtual = 1, abertaFechada;
            Casa casa = new Casa();
            Console.Write("Informe a cor da casa: ");
            casa.Pinta(Console.ReadLine());
            Console.Write("Informe o numero de portas da sua casa: ");
            casa.portas = new bool[Convert.ToInt32(Console.ReadLine())];
            for(int i = 0; i < casa.portas.Length; i++)
            {
                Console.Clear();
                Console.Write("1 - Abrir\n2 - Fechar\na {0}ª porta: ", portaAtual);
                abertaFechada = Convert.ToInt32(Console.ReadLine());
                if (abertaFechada.Equals(1))
                {
                    casa.portas[i] = true;
                }
                else if (abertaFechada.Equals(2))
                {
                    casa.portas[i] = false;
                }
                portaAtual++;
            }
            Console.Clear();
            Console.WriteLine("a casa atualmente esta pintada de {0}, contendo {1} porta(s) e {2} esta(ão) aberta(s)!",
                casa.cor, casa.TotalDePortas(), casa.QuantasPortasEstaoAbertas());
            Console.ReadKey();
        }
    }
}
