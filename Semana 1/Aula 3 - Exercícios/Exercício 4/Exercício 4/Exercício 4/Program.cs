using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Leia 3 valores que são as três notas de um aluno. 
               A seguir, calcule a média do aluno.
               Se a nota for menor que 6.0, deve exibir a nota F.
               Se a nota for de 6.0 até 7.0, deve exibir a nota D.
               Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
               Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
               Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A.
               Não esqueça de adicionar uma mensagem após a nota, 
               pode ser um simples parabéns para aprovação ou algo mais complexo.
               Exemplo de Entrada 10 8 9
               Exemplo de Saída O aluno tirou A.Parabéns!*/

            Console.Write("Nota 1: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            float nota3 = float.Parse(Console.ReadLine());


            float media = (float)(nota1 + nota2 + nota3) / 3;
            

            if (media < 6.0)
            {
                Console.WriteLine("Média Final: (F) Aluno Reprovado!");
            }

            else if (media >= 6.0 && media < 7.0)
            {
                Console.WriteLine("Média Final: (D) Aluno Em Segunda Chamada!");
            }

            else if (media >= 7.0 && media < 8.0)
            {
                Console.WriteLine("Média Final: (C) Aluno Em Recuperação!");
            }

            else if (media >= 8.0 && media < 9.0)
            {
                Console.WriteLine("Média Final: (B) Aluno Aprovado!");
            }

            else
            {
                Console.WriteLine("Média Final: (A) Aluno Aprovado, Parabéns!");
            };
                Console.ReadLine();
        }               
    }
}
