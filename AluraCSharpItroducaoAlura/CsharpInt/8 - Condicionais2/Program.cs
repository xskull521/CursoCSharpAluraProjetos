using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 8 - Condicionais2");

            int idadeJoao = 18;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine(" Pode entrar");
            }



            else
            {
                Console.WriteLine("nao pode entrar");
            }

            Console.ReadLine();
        }

    }
}

