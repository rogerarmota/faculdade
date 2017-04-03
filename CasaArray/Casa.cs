using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaArray
{
    class Casa
    {
        public string cor;
        public int totalDePortas;
        public bool[] portas;

        public void Pinta(string s)
        {
            cor = s;
        }

        public int QuantasPortasEstaoAbertas()
        {
            int abertaFechada = 0;
            foreach (bool porta in portas)
            {
                if (porta.Equals(true))
                {
                    abertaFechada += 1;
                }
            }
            return abertaFechada;
        }

        public void AdicionaPorta(bool p)
        {

        }

        public int TotalDePortas()
        {
            return portas.Length;
        }
    }
}
