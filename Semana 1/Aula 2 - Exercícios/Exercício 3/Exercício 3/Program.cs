using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia o número de horas trabalhadas de um funcionário,
             * o valor que recebe por hora e calcula o salário desse funcionário. 
             * A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
             ht = 176, vh = 50.00, sal =
             */

            double horasTrabalhadas = (double) 176;
            double valorHora = 50.00;
                       
            Console.WriteLine($"Seu salário por 176 horas de trabalho é: R$ {horasTrabalhadas * valorHora}");
            double salario = double.Parse(Console.ReadLine());
            
        }
    }
}
