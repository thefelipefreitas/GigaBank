using System;

namespace _05_GigaBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente neto = new Cliente();

            neto.Nome = "José Ferreira Neto";
            neto.CPF = "982.180.052-12";
            neto.Profissao = "Atleta";

            conta.Titular = neto;
            conta.Agencia = 1028;
            conta.Numero = 198109;
            conta.Saldo = -10;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
