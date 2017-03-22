using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class CaixaRetangular
    {
        public double comprimento, largura, altura;

        public double ObtenhoVolume()
        {
            return comprimento * largura * altura;
        }
    } 

    public class TemperaturaFahrenheit
    {
        public double graus;

        public double ObtemTemperaturaEmCelsius()
        {
            return ((graus - 32) * 5 / 9);
        }
    }

    public class Cilindro
    {
        public double raio, altura;

        public double area()
        {
            return (Math.PI * raio * raio);
        }

        public double ObtemVolume()
        {
            return area() * altura;
        }
    }

    public class Percurso
    {
        public int kilometragemInicial, kilometragemFinal;
        public double consumo;

        public int distancia()
        {
            return kilometragemFinal - kilometragemInicial;
        }

        public double ObtemGasto()
        {
            return Convert.ToDouble(distancia()) / consumo;
        }
    }

    public class Esfera
    {
        public double raio;

        public double ObtemVolume()
        {
            return (4 * Math.PI * Math.Pow(raio, 3) / 3);
        }
    }

    public class TemperaturaCelsius
    {
        public double graus;

        public double ObtemTemperaturaEmFahrenheit()
        {
            return (((9 * graus) + 160) / 5);
        }
    }

    public class Vendedor
    {
        public double salarioFixo, percentualGanho;
        public int totalVendas;

        public double ObtemSalario()
        {
            return (salarioFixo + (totalVendas * (percentualGanho / 100)));
        }
    }

    public class LataOleo
    {
        public double raio, altura;

        public double ObetemVolume()
        {
            return ((Math.PI * raio) - (2 * altura));
        }
    }

    public class Aluno
    {
        public double nota1, nota2, nota3, nota4;

        public double ObtemMediaHarmonica()
        {
            return (4 / ((1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4)));
        }

        public double ObtemMediaPonderada()
        {
            return ((nota1 * 1 + nota2 * 2) / (1 + 2));
        }
    }
}
