using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4___Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
            Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. 
            Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. 
            Este é apenas um exercício com objetivo de testar raciocínio matemático simples.*/


            int idadeAnos = 34;
            double idadeMeses = idadeAnos * 12;
            double idadeDias = idadeMeses * 365;

            Console.WriteLine($"Idade anos: " + idadeAnos);
            Console.WriteLine($"Idade em meses: " + idadeMeses);
            Console.WriteLine($"Idade em dias: " + idadeDias);
            Console.ReadLine();






        }
    }
}
