using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Triangulo
    {
        public double ladoX, ladoY, ladoZ;
        public string tipoDoTriangulo;

        public bool VerificarValores()
        {
            if (ladoX < (ladoY + ladoZ))
            {
                if (ladoY < (ladoX + ladoZ))
                {
                    if (ladoZ < (ladoX + ladoY))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string ObeterTipoTriangulo()
        {
            if (VerificarValores())
            {
                //Equilatero
                if (ladoX.Equals(ladoY) && ladoX.Equals(ladoZ))
                {
                    tipoDoTriangulo = "Equilatero";
                }
                //Isosceles
                else if (ladoX.Equals(ladoY) && (ladoX != ladoZ))
                {
                    tipoDoTriangulo = "Isosceles";
                }
                else if (ladoY.Equals(ladoZ) && (ladoY != ladoX))
                {
                    tipoDoTriangulo = "Isosceles";
                }
                else if (ladoX.Equals(ladoZ) && (ladoX != ladoY))
                {
                    tipoDoTriangulo = "Isosceles";
                }
                //Escaleno
                else if ((ladoX != ladoY) && (ladoX != ladoZ))
                {
                    tipoDoTriangulo = "Escaleno";
                }
            }
            else if (!VerificarValores())
            {
                tipoDoTriangulo = "Invalido";
            }
            

            return tipoDoTriangulo;
        }
    }
}
