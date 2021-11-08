using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
      static void Main(string[] args)
        {
               Console.WriteLine("Executando o Projeto 2 - Criando Variaveis");

              int idade;
              idade = 32;
              Console.WriteLine(idade);

              idade = 10;
              Console.WriteLine(idade);

              idade = 10 + 5;
              Console.WriteLine(idade);

              idade = 10 + 5 * 2;
              Console.WriteLine(idade);

              idade = (10 + 5) * 2;
              Console.WriteLine("Sua Idade é " + idade + "!");

              Console.WriteLine("Execução finalizada - Aperte Enter Para Finalizar");
              Console.ReadLine();
        
          
        }
    }
}
