using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaAniversario
{
    class Program
    {
        static void Main(string[] args)
        {
            int aniversariosComemorados;

            Pessoa pessoa = new Pessoa();
            Console.Write("Informe seu nome: ");
            pessoa.nome = Console.ReadLine();
            Console.Write("Informe sua idade: ");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantos aniversarios ja comemorou após a idade informada: ");
            aniversariosComemorados = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < aniversariosComemorados; i++)
            {
                pessoa.FazAniversario();
            }

            Console.Clear();
            Console.WriteLine("{0} esta com {1} anos de vida!",pessoa.nome,pessoa.idade);

            Console.ReadKey();
        }
    }
}
