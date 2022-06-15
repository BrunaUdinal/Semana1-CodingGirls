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
            /*Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.*/

            Console.WriteLine("Números: 5, 10, 15, 20, 25, 30, 35, 40, 45, 45, 50");
            Console.ReadLine();
            int num1 = 5, num2 = 10, num3 = 15, num4 = 20, num5 = 25, num6 = 30, num7 = 35, num8 = 40, num9 = 45, num10 = 50;
            Console.WriteLine($"Soma dos Valores: {num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10}");
            Console.ReadLine();
        }
    }
}
