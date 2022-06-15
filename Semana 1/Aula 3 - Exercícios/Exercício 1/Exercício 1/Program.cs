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
            /*Leia um valor de ponto flutuante com duas casas decimais. 
             * Este valor representa um valor monetário. 
             * A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. 
             * As notas consideradas são de 100, 50, 20, 10, 5, 2.
            Entrada: 576.73
            Exemplo de Saída: NOTAS: 
            5 nota(s) de R$ 100.00 
            1 nota(s) de R$ 50.00 
            1 nota(s) de R$ 20.00 
            0 nota(s) de R$ 10.00 
            1 nota(s) de R$ 5.00 
            0 nota(s) de R$ 2.00*/
            // resto R$ 76.00
            
            double valorM = 1876.00;
            int valorArredondado = (int)valorM;

            Console.WriteLine($"Notas de R$ 100.00: {valorArredondado / 100}"); // 18 de R$ 100.00
            int nota100 = int.Parse(Console.ReadLine());

            int rest1 = valorArredondado - (nota100 * 100); // resto R$ 76.00

            Console.WriteLine($"Notas de R$ 50.00: {rest1 / 50}"); // 1 de R$ 50.00
            int nota50 = int.Parse(Console.ReadLine());

            int rest2 = rest1 - 50; // resto R$ 26.00

            Console.WriteLine($"Notas de R$ 20.00: {rest2 / 20}"); // 1 de R$ 20.00
            int nota20 = int.Parse(Console.ReadLine());

            int rest3 = rest2 - (nota20 * 20); // resto R$ 6.00

            Console.WriteLine($"Notas de R$ 10.00: {rest3 / 10}"); // 0 de R$ 10.00
            int nota10 = int.Parse(Console.ReadLine());

            int rest4 = rest3 - (nota10 * 10); // resto R$ 6.00

            Console.WriteLine($"Notas de R$ 5.00: {rest4 / 5}"); // 1 de R$ 5.00
            int nota5 = int.Parse(Console.ReadLine());

            int rest5 = rest4 - (nota5 * 5); //  resto R$ 1.00

            Console.WriteLine($"Notas de R$ 2.00: {rest5 / 2}"); // 0 de R$ 2.00
            int nota2 = int.Parse(Console.ReadLine());

            // resto R$ 1.00


        }
    }
}
