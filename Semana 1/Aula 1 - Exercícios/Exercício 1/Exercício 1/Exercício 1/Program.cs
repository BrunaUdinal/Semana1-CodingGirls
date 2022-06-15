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
            string nome = "Giulia Marinho";
            string endereco = "Rua dos Anjos, 70";
            int cep = 11450490;
            double telefone = 11965278846;
            Console.WriteLine($"{nome}\n{endereco}\n{cep}\n{telefone}");
            Console.ReadLine();
        }
    }
}
