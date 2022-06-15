using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, 
             * sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.*/

            string nome = "Katherine Johnson";
            string graduacao = "Pós graduação na universidade West Virginia Statec";
            string contribuicao = "Uma de suas principais contribuições foi o cálculo de trajetória de voo para a missão de primeiro pouso na lua, feito pelo Apolo 11";
            Console.WriteLine($"{nome}\n{graduacao}\n{contribuicao}");
            Console.ReadLine();
        }
    }
}
