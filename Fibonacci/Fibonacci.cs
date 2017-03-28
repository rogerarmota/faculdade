using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {
        public int primeiroValor = 0, segundoValor = 1, fibonacci;
        
        public  int calcularFibonacci(int posicao)
        {
            if (posicao < fibonacci)
            {
                fibonacci = primeiroValor + segundoValor;
                primeiroValor = segundoValor;
                segundoValor = fibonacci;
            }
            else if (posicao >= fibonacci)
            {
                valor();
            }
        }

        public int valor()
        {
            return fibonacci;
        }
    }
}
