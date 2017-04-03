using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            int abrirFechar;
            Casa casa = new Casa();
            Console.Write("Informe a cor da(s) porta(s): ");
            casa.Pinta(Console.ReadLine());
            Console.Write("1 - Abrir\n2 - Fechar\na primeira porta: ");
            abrirFechar = Convert.ToInt32(Console.ReadLine());
            if (abrirFechar.Equals(1))
            {
                casa.porta1 = true;
            }
            else if (abrirFechar.Equals(2))
            {
                casa.porta1 = false;
            }
            Console.Write("1 - Abrir\n2 - Fechar\na segunda porta: ");
            abrirFechar = Convert.ToInt32(Console.ReadLine());
            if (abrirFechar.Equals(1))
            {
                casa.porta2 = true;
            }
            else if (abrirFechar.Equals(2))
            {
                casa.porta2 = false;
            }
            Console.Write("1 - Abrir\n2 - Fechar\na terceira porta: ");
            abrirFechar = Convert.ToInt32(Console.ReadLine());
            if (abrirFechar.Equals(1))
            {
                casa.porta3 = true;
            }
            else if (abrirFechar.Equals(2))
            {
                casa.porta3 = false;
            }
            Console.Clear();
            Console.WriteLine("a(s) porta(s) esta(ão) pintada(s) de {0}, e atualmente esta(ão) aberta(s) {1} porta(s)",
                casa.cor,casa.QuantasPortasEstaoAbertas());
            Console.ReadKey();
        }
    }
}
