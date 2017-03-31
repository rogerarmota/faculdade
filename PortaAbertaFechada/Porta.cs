using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortaAbertaFechada
{
    class Porta
    {
        public bool aberta;
        public string cor;
        public double dimensaoX, dimensaoY, dimensaoZ;

        public void Abre()
        {
            if (!aberta)
            {
                aberta = true;
            }
        }

        public void Fecha()
        {
            if (aberta)
            {
                aberta = false;
            }
        }

        public void Pinta(string s)
        {
            cor = s;
        }

        public bool EstaAberta()
        {
            return aberta;
        }
    }
}
