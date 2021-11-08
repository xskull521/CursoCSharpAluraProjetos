using System;

namespace _4__ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");

            double salario;
            salario = 4300.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            //o long é uma variavel de 64v bits (maneira certa de declarar)
            long idade = 1600000000000000;
            Console.WriteLine(idade);

            //o short é uma variavel que suporta valores ate 16bits (maneira nao muito certa)
            short quantidadeProdutos = 150;
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            double remunera = 2010.50;
            int valor = (int)salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;
            Console.WriteLine(total);


            Console.ReadLine();
        }
    }
}
