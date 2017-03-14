using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Tupiniquim
{
    class Program
    {
        static void Main(string[] args)
        {
            string area, posicaoDirecaoRobo, comando;
            int posicaoX, posicaoY, limiteX, limiteY;
            char direcao;

            Console.Write("Digite a area: ");
            area = Console.ReadLine();
            Console.Write("Digite a posição e a direção do robo: ");
            posicaoDirecaoRobo = Console.ReadLine();
            string[] arrayPosicaoDirecao = posicaoDirecaoRobo.Split(' ');
            posicaoX = Convert.ToInt32(arrayPosicaoDirecao[0]);
            posicaoY = Convert.ToInt32(arrayPosicaoDirecao[1]);
            direcao = Convert.ToChar(arrayPosicaoDirecao[2]);
            Console.Write("Digite o comando do robo: ");
            comando = Console.ReadLine();
            char[] instrucoes = comando.ToCharArray();
            foreach (char instrucao in instrucoes)
            {
                if (instrucao == 'E' | instrucao == 'e')
                {
                    if (direcao == 'N' | direcao == 'n')
                        direcao = 'O';
                    else if (direcao == 'O' | direcao == 'o')
                        direcao = 'S';
                    else if (direcao == 'S' | direcao == 's')
                        direcao = 'L';
                    else if (direcao == 'L' | direcao == 'l')
                        direcao = 'N';
                }
                else if (instrucao == 'D' | instrucao == 'd')
                {
                    if (direcao == 'N' | direcao == 'n')
                        direcao = 'L';
                    else if (direcao == 'L' | direcao == 'l')
                        direcao = 'S';
                    else if (direcao == 'S' | direcao == 's')
                        direcao = 'O';
                    else if (direcao == 'O' | direcao == 'o')
                        direcao = 'N';
                }
                else if (instrucao == 'M' | instrucao == 'm')
                {
                    if (direcao == 'N' | direcao == 'n')
                        posicaoY++;
                    else if (direcao == 'S' | direcao == 's')
                        posicaoY--;
                    else if (direcao == 'L' | direcao == 'l')
                        posicaoX++;
                    else if (direcao == 'O' | direcao == 'o')
                        posicaoX--;
                }
            }
            string[] dimensao = area.Split(' ');
            limiteX = Convert.ToInt32(dimensao[0]);
            limiteY = Convert.ToInt32(dimensao[1]);
            if (posicaoX <= limiteX && posicaoY <= limiteY)
                Console.WriteLine("Posição final do robo: {0} {1} {2}", posicaoX, posicaoY, direcao);
            else
                Console.WriteLine("Robo ultrapasou o limite da area, perca de dados!");
            Console.ReadKey();
        }
    }
}