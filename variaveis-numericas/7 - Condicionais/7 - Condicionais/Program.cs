using System;

class Programa
{
    static void Main(string[] args)
    {

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele esta acompanhado, pode entrar");
            }
            else
            {
                Console.WriteLine("Nao pode entrar!");
            }
        }

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}