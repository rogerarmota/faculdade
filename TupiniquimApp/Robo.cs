using System;

namespace TupiniquimApp
{
    public class Robo
    {
        public char direcao;
        public int posicaoX, posicaoY;

        public void Explorer(string comando)
        {
            char[] instrucoes = comando.ToCharArray();
            foreach (char instrucao in instrucoes)
            {
                if (instrucao == 'M' | instrucao == 'm')
                    Mover();
                else if (instrucao == 'E' | instrucao == 'e')
                    VirarEsquerda();
                else if (instrucao == 'D' | instrucao == 'd')
                    VirarDireira();
            }
        }

        public string ObtemPosicaoFinal()
        {
            return posicaoX + " " + posicaoY + " " + direcao;
        }

        private void Mover()
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

        private void VirarEsquerda()
        {
            if (direcao == 'N' | direcao == 'n')
                direcao = 'O';

            else if (direcao == 'S' | direcao == 's')
                direcao = 'L';

            else if (direcao == 'L' | direcao == 'l')
                direcao = 'N';

            else if (direcao == 'O' | direcao == 'o')
                direcao = 'S';
        }

        private void VirarDireira()
        {
            if (direcao == 'N' | direcao == 'n')
                direcao = 'L';

            else if (direcao == 'S' | direcao == 's')
                direcao = 'O';

            else if (direcao == 'L' | direcao == 'l')
                direcao = 'S';

            else if (direcao == 'O' | direcao == 'o')
                direcao = 'N';
        }
    }
}