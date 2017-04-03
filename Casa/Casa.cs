using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa
{
    class Casa
    {
        public string cor;
        public bool porta1, porta2, porta3;

        public void Pinta(string s)
        {
            cor = s;
        }

        public int QuantasPortasEstaoAbertas()
        {
            int numeroPortasAbertas = 0;

            if (porta1)
            {
                numeroPortasAbertas += 1;
            }
            if (porta2)
            {
                numeroPortasAbertas += 1;
            }
            if (porta3)
            {
                numeroPortasAbertas += 1;
            }

            return numeroPortasAbertas;
        }
    }
}
