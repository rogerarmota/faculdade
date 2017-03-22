using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int exe = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\nEXERCICIOS");
                Console.WriteLine();
                Console.WriteLine("1 - Volume de Caixa Retangular");
                Console.WriteLine("2 - Converter de graus Fahrenheit para graus Celsius");
                Console.WriteLine("3 - Volume do Cilindro");
                Console.WriteLine("4 - Consumo de Combustível");
                Console.WriteLine("5 - Volume da Esfera");
                Console.WriteLine("6 - Converter de graus Celsius para graus Fahrenheit");
                Console.WriteLine("7 - Salario do Vendedor");
                Console.WriteLine("8 - Volume da Lata de Oleo");
                Console.WriteLine("9 - Média Harmônica");
                Console.WriteLine("10 - Média Ponderada");
                Console.WriteLine("11 - SAIR");
                Console.Write("\nInforme o numero de qual deseja acessar: ");
                exe = Convert.ToInt32(Console.ReadLine());
                switch (exe)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n               Volume de Caixa Retangular");
                        CaixaRetangular caixa = new CaixaRetangular();
                        Console.Write("\nInforme a altura da caixa: ");
                        caixa.altura = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe a largura da caixa: ");
                        caixa.largura = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe o comprimento da caixa: ");
                        caixa.comprimento = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Volume da caixa: {0}", caixa.ObtenhoVolume());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n               Converter de graus Fahrenheit para graus Celsius");
                        TemperaturaFahrenheit temperatura = new TemperaturaFahrenheit();
                        Console.Write("\nInforme a temperatura em Fahrenheit: ");
                        temperatura.graus = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Temperatura em Celsius: {0}", temperatura.ObtemTemperaturaEmCelsius());
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n              Volume do Cilindro");
                        Cilindro cilindro = new Cilindro();
                        Console.Write("\nInforme o raio do cilindro: ");
                        cilindro.raio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Volume do cilindro: {0}",cilindro.ObtemVolume());
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n               Consumo de Combustível");
                        Percurso viagemCasa = new Percurso();
                        Console.Write("\nInforme a kilometragem inicial: ");
                        viagemCasa.kilometragemInicial = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe a kilometragem final: ");
                        viagemCasa.kilometragemFinal = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o consumo de combustivel: ");
                        viagemCasa.consumo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Consumo: {0} km/l", viagemCasa.ObtemGasto());
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\n               Volume da Esfera");
                        Esfera esfera = new Esfera();
                        Console.Write("\nInforme o raio da esfera: ");
                        esfera.raio = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Volume da esfera: {0}", esfera.ObtemVolume());
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("\n               Converter de graus Celsius para graus Fahrenheit");
                        TemperaturaCelsius temperaturaCelsius = new TemperaturaCelsius();
                        Console.Write("\nInforme a temperatura em Celsius: ");
                        temperaturaCelsius.graus = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Temperatura em Fahrenheit: {0}", temperaturaCelsius.ObtemTemperaturaEmFahrenheit());
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("\n               Salario do Vendedor");
                        Vendedor funcionario = new Vendedor();
                        Console.Write("\nInforme o salario: ");
                        funcionario.salarioFixo = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe o total de vendas: ");
                        funcionario.totalVendas = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o percentual de vendas: ");
                        funcionario.percentualGanho = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Salario do vendedor: {0}", funcionario.ObtemSalario());
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("\n               Volume da Lata de Oleo");
                        LataOleo lata = new LataOleo();
                        Console.Write("\nInforme o raio da lata: ");
                        lata.raio = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe a altura da lata: ");
                        lata.altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Volume da lata de oleo: {0}", lata.ObetemVolume());
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("\n               Média Harmônica");
                        Aluno aluno = new Aluno();
                        Console.Write("\nInforme a 1ª nota: ");
                        aluno.nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe a 2ª nota: ");
                        aluno.nota2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe a 3ª nota: ");
                        aluno.nota3 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe a 4ª nota: ");
                        aluno.nota4 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Media Harmonica: {0}", aluno.ObtemMediaHarmonica());
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("\n              Média Ponderada");
                        Aluno alunoo = new Aluno();
                        Console.Write("\nInforme a 1ª nota: ");
                        alunoo.nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe a 2ª nota: ");
                        alunoo.nota2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Media ponderada: {0}", alunoo.ObtemMediaPonderada());
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inexistente!");
                        break;
                }
            } while (exe != 11);
        }
    }
}
