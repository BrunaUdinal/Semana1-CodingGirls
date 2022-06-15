using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.*/

            Console.WriteLine("Qual o seu ano de nascimento?");
            int anoNasc = int.Parse(Console.ReadLine());

            Console.WriteLine($"Idade: {2022 - anoNasc} anos");
            Console.ReadLine();
        }
    }
}
