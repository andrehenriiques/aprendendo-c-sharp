using System;

class Programa
{
    static void Main(string[] args)
    {

        double investimento = 1000;

        //rendimento de 0.5% (0.005) ao mes

        int mes = 1;

        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mes " + mes + " voce tem R$" + investimento);
            mes += 1;

        }


        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}