using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
            Salário de 0 até 400.00 ganha 15% 
            Salário de 400.01 até 800.00 ganha 12% 
            Salário de 800.01 até 1200.00 ganha 10% 
            Salário de 1200.01 até 2000.00 ganha 7% 
            Acima de 2000.00 ganha 4%
            Leia o salário do funcionário e calcule e mostre o novo salário, 
            bem como o valor de reajuste ganho e o índice reajustado, em percentual.
            Exemplo de Entrada 400.00
            Exemplo de Saída Novo salario: 460.00 Reajuste ganho: 60.00 Em percentual: 15 %*/

            Console.Write("Salário R$: ");
            double salario = double.Parse(Console.ReadLine());

            double reajuste15 = salario + (salario * 0.15);
            double reajuste12 = salario + (salario * 0.12);
            double reajuste10 = salario + (salario * 0.10);
            double reajuste7 = salario + (salario * 0.7);
            double reajuste4 = salario + (salario * 0.4);
            {
                if (salario > 0.00 && salario <= 400.00)
                {
                    Console.WriteLine("Novo salario: R$ " , reajuste15);
                    Console.ReadLine();
                    Console.WriteLine($"Reajuste ganho: R$ {reajuste15 - salario} Em percentual: 15%");
                    Console.ReadLine();
                }
                else if (salario > 400.00 && salario <= 800.00)
                {
                    Console.WriteLine("Novo salario: R$ " , reajuste12);
                    Console.ReadLine();
                    Console.WriteLine($"Reajuste ganho: R$ {reajuste12 - salario} Em percentual: 12%");
                    Console.ReadLine();
                }
                else if (salario > 800.00 && salario <= 1200.00)
                {
                    Console.WriteLine("Novo salario: R$ " , reajuste10);
                    Console.ReadLine();
                    Console.WriteLine($"Reajuste ganho: R$ {reajuste10 - salario} Em percentual: 10%");
                    Console.ReadLine();
                }
                else if (salario > 1200.00 && salario <= 2000.00)
                {
                    Console.WriteLine("Novo salario: R$ ", reajuste7);
                    Console.ReadLine();
                    Console.WriteLine($"Reajuste ganho: R$ {reajuste7 - salario} Em percentual: 7%");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Novo salario: R$ " , reajuste4);
                    Console.ReadLine();
                    Console.WriteLine($"Reajuste ganho: R$ {reajuste4 - salario} Em percentual: 4%");
                    Console.ReadLine();
                };

                Console.ReadLine();

            }
        }
    }
}
