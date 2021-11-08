using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupanca");

            double valorInvestido = 1000;
            int contadorMes = 1;

           while (contadorMes <= 12)
                {

                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("apos " + contadorMes + " mês, voce tera R$" + valorInvestido);

                //  contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }

            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("apos 1 mês, voc~e tera R$" + valorInvestido);
            //0.36% = 0.0036


            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("apos 2 mes, voce tera R$" + valorInvestido);





            Console.ReadLine();

        }
    }
}
