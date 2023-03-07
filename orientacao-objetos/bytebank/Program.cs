using bytebank.Contas;
using bytebank.Titular;
using System;

class Programa
{
    static void Main(string[] args)
    {
        /* ContaCorrente contaDoAndre = new ContaCorrente();

         contaDoAndre.titular = "Andre Silva";
         contaDoAndre.numeroAgencia = 15;
         contaDoAndre.conta = "1010-X";
         contaDoAndre.saldo = 100;


         ContaCorrente contaDaMaria = new ContaCorrente();

         contaDaMaria.titular = "Maria";
         contaDaMaria.numeroAgencia = 17;
         contaDaMaria.conta = "2020-X";
         contaDaMaria.saldo = 350;

         Console.WriteLine("Saldo Maria: R$ " + contaDaMaria.saldo);
         Console.WriteLine("Saldo Andre: R$ " + contaDoAndre.saldo);

         contaDoAndre.Transferir(100, contaDaMaria);

         Console.WriteLine("Saldo Maria: R$ " + contaDaMaria.saldo);
         Console.WriteLine("Saldo Andre: R$ " + contaDoAndre.saldo);


         ContaCorrente contaDoPedro = new ContaCorrente();

         Console.WriteLine("Conta Pedro: " + contaDoPedro.conta);


         Console.WriteLine(contaDoAndre);
         Console.WriteLine("Agencia " + contaDoAndre.numeroAgencia);
        Console.WriteLine("Conta " + contaDoAndre.conta);
        Console.WriteLine("Saldo R$ " + contaDoAndre.saldo);

       contaDoAndre.Depositar(100);


        Console.WriteLine("Saldo pos deposito: R$ " + contaDoAndre.saldo);


        if (contaDoAndre.Sacar(100))
        {
            Console.WriteLine("Saldo pos deposito: R$ " + contaDoAndre.saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }

        double valor = 300;
        double valor2 = valor;

        Console.WriteLine(valor == valor2);
        Console.WriteLine(valor);
        Console.WriteLine(valor2);

        ContaCorrente conta = new ContaCorrente();
        ContaCorrente contaDoAndre = new ContaCorrente();

        contaDoAndre.titular = "Andre Silva";
        contaDoAndre.numeroAgencia = 15;
        contaDoAndre.conta = "1010-X";
        contaDoAndre.saldo = 100;


        ContaCorrente contaDoAndre2 = new ContaCorrente();

        contaDoAndre2.titular = "Andre Silva";
        contaDoAndre2.numeroAgencia = 15;
        contaDoAndre2.conta = "1010-X";
        contaDoAndre2.saldo = 100;

        contaDoAndre = contaDoAndre2;

        Console.WriteLine(contaDoAndre == contaDoAndre2);


        Cliente cliente = new Cliente();

        cliente.nome = "Andre Silva";
        cliente.cpf = "123456789";
        cliente.profissao = "123456789";

        ContaCorrente conta = new ContaCorrente();

        conta.titular = cliente;
        conta.conta = "1010-X";
        conta.numeroAgencia = 15;
        conta.saldo = 100;

        Console.WriteLine("Titular " + conta.titular.nome);
        Console.WriteLine("CPF " + conta.titular.cpf);
        Console.WriteLine("Profissao " + conta.titular.profissao);


        ContaCorrente conta2 = new ContaCorrente();
        conta2.titular = new Cliente();

        conta2.titular.nome = "Jose Silva";
        conta2.titular.profissao = "Tester";
        conta2.titular.cpf = "987654321";
        conta2.numeroAgencia = 18;
        conta2.saldo = 500;


        Console.WriteLine(conta2.titular.nome);


        ContaCorrente conta3 = new ContaCorrente();
        conta3.NumeroAgencia = 18;
        conta3.Conta = "1011-H";
        conta3.SetSaldo(-10);

        Console.WriteLine(conta3.GetSaldo());
        Console.WriteLine(conta3.NumeroAgencia);
        Console.WriteLine(conta3.Conta);

        ContaCorrente conta4 = new ContaCorrente( 18 , "1010-X");

        conta4.SetSaldo(500);
        conta4.Titular = new Cliente();

        Console.WriteLine(conta4.GetSaldo());
        Console.WriteLine(conta4.NumeroAgencia);*/


        ContaCorrente conta5 = new ContaCorrente(19, "1011-X");

        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        //ContaCorrente.TotalDeContasCriadas = 100;

        ContaCorrente conta6 = new ContaCorrente(20, "1234-X");

        conta5.Titular = new Cliente();
        conta6.Titular = new Cliente();

        Console.WriteLine(Cliente.TotalClientesCadastrados);

        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

    }
}
