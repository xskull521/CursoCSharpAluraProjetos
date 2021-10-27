using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = false;
            string mensagemAdicional;


            if (acompanhado == true)
            {
                mensagemAdicional = "jaoo esta acompanhado";
            }
            else
            {
                mensagemAdicional = "não esta acompanhado";
            }
 
            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine(" Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }



            else
            {
                Console.WriteLine("nao pode entrar");
            }

            Console.ReadLine();
        }
    }
}