using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;
           /*inicialização acontece| Depoois Valida essa|E por ultimo a atribuição  
          antes da inicialização do| Condição Booleana  |desta variavel.
           laço*/                                      
           for (int contadorMes = 1; contadorMes <= 12;  contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("após " + contadorMes + "meses, você terá R$" + valorInvestido);
            }
            Console.ReadLine();
        }
    }
}
