using System;

namespace _7___Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 7 - Condicionais");

            int idadeJoao = 17;
            int quantidadePessoas = 2;
             
            if (idadeJoao >= 18)
            {
                Console.WriteLine("joao possui mais de 18 anos, Pode entrar");
            }

            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("Joao não possui 18 anos, mas esta acompanhado, pode entrar");
                }
                else
                {
                    Console.WriteLine("Joao não possui mais de 18 anos, nao pode entrar");
                }
                
            }

        }
    }
}
