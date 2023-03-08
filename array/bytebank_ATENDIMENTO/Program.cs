using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


//TestaArrayInt();
//TestaBuscarPalavra

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 13;
    idades[4] = 22;

    Console.WriteLine($"Tamanho {idades.Length}");

    int acumulador = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Índice [{i}] = {idade}");
        acumulador += idade;
    }

    Console.WriteLine($"Total das datas: {acumulador}");
    Console.WriteLine($"Média: {acumulador / idades.Length}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.WriteLine($"Digite {i + 1} palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
    }
}

Array amostra = Array.CreateInstance(typeof(double), 5);

amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(5.8, 2);
amostra.SetValue(9.3, 3);
amostra.SetValue(2.7, 4);

//TestaMediana(amostra);

void TestaMediana(Array array)
{
    if (array == null || array.Length == 0)
    {
        Console.WriteLine("Array para calculo da mediana está vazio ou nulo");
    }
    else
    {
        double[] numerosOrdenados = (double[])array.Clone();
        Array.Sort(numerosOrdenados);

        int tamanho = numerosOrdenados.Length;
        int meio = tamanho / 2;
        double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
        Console.WriteLine($"A mediana = {mediana}");
    }

    int[] valores = { 10, 5, 36, 47 };

    for (int i = 0; i < valores.Length; i++)
    {
        Console.WriteLine(valores[i]);
    }
}

TestaArrayDeContasCorrentes();

void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "8172389-A"));
    listaDeContas.Adicionar(new ContaCorrente(884, "534354354-B"));
    listaDeContas.Adicionar(new ContaCorrente(894, "45634545-C"));
    listaDeContas.Adicionar(new ContaCorrente(824, "465645645-D"));

    var contaDoAndre = new ContaCorrente(824, "123456-E");
    listaDeContas.Adicionar(contaDoAndre);
    listaDeContas.ExibeLista();
    Console.WriteLine("________________________________");

    listaDeContas.Remover(contaDoAndre);
    listaDeContas.ExibeLista();

    // listaDeContas.Remover();

    //Console.WriteLine(listaDeContas.VerificarMaiorSaldo());

    //for (int i = 0; i < listaDeContas.Length; i++)
    //{
    //    ContaCorrente contaAtual = listaDeContas[i];
    //    Console.WriteLine($"Conta {contaAtual.Conta} ");
    //}
}