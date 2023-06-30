using ByteBankIO;

//LidandoComFileStreamDiretamente();

//EscritaBinaria();
//LeituraBinaria();

UsarStreamDeEntrada();

static void UsarStreamDeEntrada()
{

    using (var fluxoDeEntrada = Console.OpenStandardInput())
    using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
    {
        var buffer = new byte[1024];
        while (true)
        {
            var byteslidos = fluxoDeEntrada.Read(buffer, 0, 1024);
            fs.Write(buffer, 0, byteslidos);
            fs.Flush();
            Console.WriteLine($"bytes lidos na console: {byteslidos}");
        }
    }
}

Console.ReadLine();

static void EscritaBinaria()
{

    using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
    using (var escritor = new BinaryWriter(fs))
    {
        escritor.Write(456);
        escritor.Write(45245);
        escritor.Write(2424.50);
        escritor.Write("Gustavo Braga");
    }
}

static void LeituraBinaria()
{
    using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
    using (var leitor = new BinaryReader(fs))
    {
        var agencia = leitor.ReadInt32();
        var numeroConta = leitor.ReadInt32();
        var saldo = leitor.ReadDouble();
        var titular = leitor.ReadString();

        Console.WriteLine($"Ag {agencia}, Numero {numeroConta}, Saldo {saldo}, Titular {titular}");
    }
}

//TestaEscrita();

//CriarArquivoComWrite();

//static void CriarArquivoComWrite()
//{
//    var caminhoNovoArquivo = "testaEscrita.txt";

//    using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))  
//    using (var escritor = new StreamWriter(fluxoDeArquivo))
//    {
//        escritor.WriteLine(true);
//        escritor.WriteLine(false);
//        escritor.WriteLine(3443434343);
//    }

//    Console.WriteLine("Aplicacao Finalizada");
//}

Console.ReadLine();

#region
//var enderecoDoArquivo = "contas.txt";

//using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
//{
//    var leitor = new StreamReader(fluxoDeArquivo);

//    while (!leitor.EndOfStream)
//    {
//        var linha = leitor.ReadLine();
//        var contaCorrente = ConverterStringParaContaCorrente(linha);

//        var msg = $"Conta número {contaCorrente.Titular.Nome}, Conta número {contaCorrente.Numero}, ag {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo}";

//        Console.WriteLine(msg);

//    }
//}
//Console.ReadLine();


//static ContaCorrente ConverterStringParaContaCorrente(string linha)
//{
//    // 375 4644 2483.13 Jonatan
//    var campos = linha.Split(',');
//    var agencia = campos[0];
//    var numero = campos[1];
//    var saldo = campos[2].Replace('.', ',');
//    var nomeTitular = campos[3];

//    var agenciaComInt = int.Parse(agencia);
//    var numeroComInt = int.Parse(numero);
//    var saldoComDouble = double.Parse(saldo);

//    var titular = new Cliente();
//    titular.Nome = nomeTitular;

//    var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
//    resultado.Depositar(saldoComDouble);
//    resultado.Titular = titular;

//    return resultado;
//}

#endregion