using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5___Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Construa um conversor de moedas:
            Crie um programa que solicite um um valor em real ao usuário e converta esse valor, para:
            DOLAR
            EURO
            LIBRA ESTERLINA
            DÓLAR CANADENSE
            PESO ARGENTINO
            PESO CHILENO
            Para esse exercício você precisará realizar uma pesquisa para saber a cotação de cada moeda em real. 
            Mostrar o resultado no formato símbolo da moeda e valor, como o exemplo R$ 10,00 para a moeda real.*/
            
            float dolar, euro, libraEsterlina, dolarCanadense, pesoArgentino, pesoChileno;
            Console.Write("Digite o valor a ser convertido: R$ ");
            float reais = float.Parse(Console.ReadLine());

            Console.WriteLine($"Dolar: U$ {dolar = reais * 4.90f}\nEuro: € {euro = reais * 5.24f}\nLibra Esterlina: £ {libraEsterlina = reais * 6.15f}\nDólar Canadense: C$ {dolarCanadense = reais * 3.90f}\nPeso Argentino: $ {pesoArgentino = reais * 0.040f}\nPeso Chileno: CLP$ {pesoChileno = reais * 0.0059f}");
            Console.ReadLine();
           
            
        } 
    }
}
