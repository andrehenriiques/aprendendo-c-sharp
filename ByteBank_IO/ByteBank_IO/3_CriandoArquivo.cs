using System;
using System.Text;
using ByteBankIO;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        //{
        //    var contaComoString = "456, 7894, 1312.30, Gustavo Santos";

        //    var encoding = Encoding.UTF8;

        //    var bytes = encoding.GetBytes(contaComoString);

        //    fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        //}

        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("123,23423,123.32,Pedro");
        }
    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "text.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create)) 
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for(int i=0; i<100000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); //Despeja o buffer para o Stream
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter....");
                Console.ReadLine();
            } 
        }
    }
}

