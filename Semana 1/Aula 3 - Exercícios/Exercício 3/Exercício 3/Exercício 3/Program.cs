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
            /*Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno. 
             * Considere que cada nota pode ir de 0 até 10.0, 
             * sempre com uma casa decimal. Imprima se o aluno foi aprovado ou reprovado considerando a média 7.*/

            double n1 = 8.0;
            double n2 = 9.0;
            double n3 = 10.0;
            

            double media = (double)(n1 + n2 + n3) / 3;

            string result = (media < 7.0) ? "Reprovado!" : "Aprovado!";

            Console.WriteLine($"Sua média é: {media}\n{result}");
            Convert.ToDouble(Console.ReadLine());


        }
    }
}
