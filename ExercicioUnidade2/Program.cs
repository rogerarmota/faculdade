using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUnidade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.nome = "Roger";
            funcionario.departamento = "Suporte";
            funcionario.rg = "5193914";
            funcionario.salario = 100;
            funcionario.bonifica(50);
            funcionario.estaNaEmpresa = false;

            Data data = new Data();
            data.dia = 27;
            data.mes = 03;
            data.ano = 2017;
            funcionario.dataEntrada = data;

            funcionario.mostrar();

            Console.ReadKey();
        }
    }
}
