using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            Console.Write("Informe o valor do lado X do triangulo: ");
            triangulo.ladoX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor do lado Y do triangulo: ");
            triangulo.ladoY = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o valor do lado Z do triangulo: ");
            triangulo.ladoZ = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Pelos valres informados o triangulo é {0}!!",triangulo.ObeterTipoTriangulo());
            
            Console.ReadKey();
        }
    }
}
