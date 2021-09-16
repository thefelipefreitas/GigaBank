using System;

namespace _05_GigaBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente client = new Cliente();

            client.Nome = "José Ferreira Neto";
            client.CPF = "982.180.052-12";
            client.Profissao = "Atleta";

            conta.Titular = client;
            conta.Agencia = 1028;
            conta.Numero = 198109;
            conta.Saldo = -10;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
