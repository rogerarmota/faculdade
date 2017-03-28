using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    class Funcionario
    {
        public string nome, departamento, rg;
        public double salario;
        public bool estaNaEmpresa;
        public Data dataEntrada;

        public void bonifica(double aumenta)
        {
            salario += aumenta;
        }

        public void demite()
        {
            estaNaEmpresa = false;
        }

        public void mostrar()
        {
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Departamento: {0}", departamento);
            Console.WriteLine("RG: {0}", rg);
            Console.WriteLine("Dia: {0}", dataEntrada.dia);
            Console.WriteLine("Mês: {0}", dataEntrada.mes);
            Console.WriteLine("Ano: {0}", dataEntrada.ano);
            Console.WriteLine("Salario: {0}", salario);
            if (estaNaEmpresa)
            {
                Console.WriteLine("Esta trabalando!");
            }
            else if (!estaNaEmpresa)
            {
                Console.WriteLine("Ja se desligou da empresa!");
            }
        }
    }

    public class Data
    {
        public int dia, mes, ano;
    }
}

