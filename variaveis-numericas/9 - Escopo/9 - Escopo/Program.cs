using System;

class Programa
{
    static void Main(string[] args)
    {

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if(acompanhado)
        {
            textoAdicional = "Joao esta acompanhado"
        }
        else
        {
            textoAdicional = "Joao nao esta acompanhado"
        }

        if (idadeJoao >= 18 && acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else Console.WriteLine("Nao pode entrar!");

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}