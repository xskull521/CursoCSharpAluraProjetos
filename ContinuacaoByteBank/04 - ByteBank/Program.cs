﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            
            bool resultadoSaque = contaDoBruno.Sacar(50);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);


            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela" + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela" + contaDaGabriela.saldo);

            Console.WriteLine("resultadoTransferencia " + resultadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);
            Console.WriteLine("Saldo do Bruno" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela" + contaDaGabriela.saldo);




            Console.ReadLine();
        }
    }
}
