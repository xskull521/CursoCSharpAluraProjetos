using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Cliente gabriela = new Cliente();
      
           // gabriela.nome = "Gabriela";
          //  gabriela.profissao = "Desenvolvedora c#";
           // gabriela.cpf = "135.332.254-63";


            
            ContaCorrente conta = new ContaCorrente();
         //   conta.titular = "gabriela";
            //conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "135.332.254-63";
            conta.titular.profissao = "Desenvolvedora c#";

           // conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 572;
            conta.numero = 43213123;

          //  Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
