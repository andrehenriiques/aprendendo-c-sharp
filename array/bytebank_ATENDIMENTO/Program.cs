using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


new ByteBankAtendimento().AtendimentoCliente();


#region Exemplos Arrays em C#
//TestaArrayInt();
//TestaBuscarPalavra

//void TestaArrayInt()
//{
//    int[] idades = new int[5];
//    idades[0] = 30;
//    idades[1] = 40;
//    idades[2] = 17;
//    idades[3] = 13;
//    idades[4] = 22;

//    Console.WriteLine($"Tamanho {idades.Length}");

//    int acumulador = 0;

//    for (int i = 0; i < idades.Length; i++)
//    {
//        int idade = idades[i];
//        Console.WriteLine($"Índice [{i}] = {idade}");
//        acumulador += idade;
//    }

//    Console.WriteLine($"Total das datas: {acumulador}");
//    Console.WriteLine($"Média: {acumulador / idades.Length}");
//}

//void TestaBuscarPalavra()
//{
//    string[] arrayDePalavras = new string[5];

//    for (int i = 0; i < arrayDePalavras.Length; i++)
//    {
//        Console.WriteLine($"Digite {i + 1} palavra: ");
//        arrayDePalavras[i] = Console.ReadLine();
//    }

//    Console.WriteLine("Digite palavra a ser encontrada: ");
//    var busca = Console.ReadLine();

//    foreach (string palavra in arrayDePalavras)
//    {
//        if (palavra.Equals(busca))
//        {
//            Console.WriteLine($"Palavra encontrada = {busca}");
//            break;
//        }
//    }
//}

//Array amostra = Array.CreateInstance(typeof(double), 5);

//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(5.8, 2);
//amostra.SetValue(9.3, 3);
//amostra.SetValue(2.7, 4);

//TestaMediana(amostra);

//void TestaMediana(Array array)
//{
//    if (array == null || array.Length == 0)
//    {
//        Console.WriteLine("Array para calculo da mediana está vazio ou nulo");
//    }
//    else
//    {
//        double[] numerosOrdenados = (double[])array.Clone();
//        Array.Sort(numerosOrdenados);

//        int tamanho = numerosOrdenados.Length;
//        int meio = tamanho / 2;
//        double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
//        Console.WriteLine($"A mediana = {mediana}");
//    }

//    int[] valores = { 10, 5, 36, 47 };

//    for (int i = 0; i < valores.Length; i++)
//    {
//        Console.WriteLine(valores[i]);
//    }
//}

//TestaArrayDeContasCorrentes();

//void TestaArrayDeContasCorrentes()
//{
    //ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    //listaDeContas.Adicionar(new ContaCorrente(874, "8172389-A"));
    //listaDeContas.Adicionar(new ContaCorrente(884, "534354354-B"));
    //listaDeContas.Adicionar(new ContaCorrente(894, "45634545-C"));
    //listaDeContas.Adicionar(new ContaCorrente(824, "465645645-D"));

    //var contaDoAndre = new ContaCorrente(824, "123456-E");
    //listaDeContas.Adicionar(contaDoAndre);


    //for (int i = 0; i< listaDeContas.Tamanho; i++)
    //{
    //    ContaCorrente conta = listaDeContas[i];
    //    Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
    //}

    //try
    //{
    //    listaDeContas.RecuperarContaNoIndex(30);
    //}
    //catch (Exception e)
    //{
    //    Console.WriteLine(e.Message);
    //}


    //listaDeContas.ExibeLista();
    //Console.WriteLine("________________________________");

    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    // listaDeContas.Remover();

    //Console.WriteLine(listaDeContas.VerificarMaiorSaldo());

    //for (int i = 0; i < listaDeContas.Length; i++)
    //{
    //    ContaCorrente contaAtual = listaDeContas[i];
    //    Console.WriteLine($"Conta {contaAtual.Conta} ");
    //}
//}

#endregion


#region
//Generica<int> test1 = new Generica<int>();
//test1.MostrarMensagem(10);

//Generica<string> test2 = new Generica<string>();
//test2.MostrarMensagem("olá");

//public class Generica<T>
//{
//    public void MostrarMensagem(T t)
//    {
//        Console.WriteLine($"Exibindo {t}");
//    }
//};

//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C")
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(951, "5679787-E"),
//    new ContaCorrente(321, "4456668-F"),
//    new ContaCorrente(719, "7781438-G")
//};

//_listaDeContas2.AddRange(_listaDeContas3);

//_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n_______________________\n\n");

//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n_______________________\n\n");

//_listaDeContas3.Clear();
//for (int i = 0; i < _listaDeContas3.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas3[i].Conta}]");
//}


//List<string> nomesDosEscolhidos = new List<string>()
//{
//    "Bruce Wayne",
//    "Carlos Vilagran",
//    "Richard Grayson",
//    "Bob Kane",
//    "Will Farrel",
//    "Lois Lane",
//    "General Welling",
//    "Perla Letícia",
//    "Uxas",
//    "Diana Prince",
//    "Elisabeth Romanova",
//    "Anakin Wayne"
//};

//bool VerificaNomes(List<string> nomesDosEscolhidos, string escolhido)
//{
//    return nomesDosEscolhidos.Contains(escolhido);
//}

//VerificaNomes(nomesDosEscolhidos, "Bob Kane");
#endregion