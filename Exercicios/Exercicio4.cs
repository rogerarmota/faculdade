using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Exercicio4
    {
        static void Main1(String[] args)
        {
            int KI, KF, DP;
            double CC, GC;
            Console.WriteLine("CONSUMO DE COMBUSTIVEL");
            Console.WriteLine();
            Console.Write("Informe a kilometragem inicial: ");
            KI = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a kilometragem final: ");
            KF = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o consumo de combustivel: ");
            CC = Convert.ToInt32(Console.ReadLine());
            DP = (KF - KI);
            GC = (DP / CC);
            Console.WriteLine();
            Console.WriteLine("Consumo: {0} km/l", GC);
            Console.ReadKey();
        }
    }
}
