using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupiniquimApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Robo robocop = new Robo();
            robocop.posicaoX = 1;
            robocop.posicaoY = 2;
            robocop.direcao = 'N';
            robocop.Explorer("EMEMEMEMM");
            Console.WriteLine(robocop.ObtemPosicaoFinal());
            Console.ReadKey();
        }
    }
}
