using bytebank_ADM;
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
#region
//Funcionario pedro = new Funcionario("1234456763", 2000);

//pedro.Nome = "Pedro";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());



//Diretor roberta = new Diretor("56463354345");

//roberta.Nome = "Roberta";


//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());


//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);


//Console.WriteLine("Total de bonificacoes R$" + gerenciador.TotalDeBonificacao);
//Console.WriteLine(roberta.GetBonificacao());

//Console.WriteLine(pedro.Salario);
//Console.WriteLine(roberta.Salario);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine(pedro.Salario);
//Console.WriteLine(roberta.Salario);
#endregion

//CalcularBonificacao();
UserSistema();

void CalcularBonificacao(){

    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    Designers ulisses = new Designers("6455645546");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("4323423");
    paula.Nome = "Paula Souza";


    Auxiliar igor = new Auxiliar("8765587656");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("74562345");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificacao = R$" + gerenciador.TotalDeBonificacao);
}


void UserSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("6857456");
    ingrid.Nome = "Ingrid Macedo";
    ingrid.Senha = "123";


    GerenteDeContas ursula = new GerenteDeContas("54354345");
    ursula.Nome = "Ingrid Macedo";
    ursula.Senha = "321";

    //Auxiliar henrique = new Auxiliar("6878767");
    //henrique.Nome = "Henrique Nunes";
    //henrique.Senha = "321";


    //Designers clovis = new Designers("6878767");
    //clovis.Nome = "Clovis Alberto";
    //clovis.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");
    sistema.Logar(caio, "999");
}