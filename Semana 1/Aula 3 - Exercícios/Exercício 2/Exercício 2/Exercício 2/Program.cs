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
            /*Faça um programa que leia três valores e apresente 
           o maior dos três valores lidos seguido da mensagem “x é o maior”.
           Exemplo de Entrada 7 14 106
           Exemplo de Saída 106 é o maior*/

            int num1 = 10;
            int num2 = 76;
            int num3 = 1987;

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} é o maior");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} é o maior");

            }
            else {
                Console.WriteLine($"{num3} é o maior");
            }
            Console.ReadLine();

            

            


           


        }
    }
}
