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
            if (posicao <= 2)
                return 1;
            else
                return calcularFibonacci(posicao - 1) + calcularFibonacci(posicao - 2);
        }
    }
}
