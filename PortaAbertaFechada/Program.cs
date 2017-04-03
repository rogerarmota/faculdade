using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortaAbertaFechada
{
    class Program
    {
        static void Main(string[] args)
        {
            int abrirFechar;
            Porta porta = new Porta();
            Console.Write("Informe a altura da porta: ");
            porta.dimensaoX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a largura da porta: ");
            porta.dimensaoY = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a dimensao da porta: ");
            porta.dimensaoZ = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a cor da porta: ");
            porta.Pinta(Console.ReadLine());
            Console.Write("1 - Abre a porta\n2 - Fecha a porta\nVode deseja: ");
            abrirFechar = Convert.ToInt32(Console.ReadLine());
            if (abrirFechar.Equals(1))
            {
                porta.aberta = true;
            }
            else if (abrirFechar.Equals(2))
            {
                porta.aberta = false;
            }
            Console.Clear();
            Console.WriteLine("A porta tem a cor {0}, com {1} de altura, {2} de largura e" 
                +" {3} de espesura e no momento a porta se encontra {4}",porta.cor,porta.dimensaoX,porta.dimensaoY,porta.dimensaoZ,
                porta.EstaAberta()?"aberta":"fechada");

            Console.ReadKey();
        }
    }
}
