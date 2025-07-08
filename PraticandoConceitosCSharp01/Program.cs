using System.Text;

bool executar = true;
do
{
    Console.WriteLine("\nPRATICANDO CONCEITOS 01");
    ExibirOpcoes();
    ExecutarOpcoes();

} while (executar);

void ExibirOpcoes()
{
    Console.WriteLine("\t1. Boas Vindas");
    Console.WriteLine("\t2. Nome e Sobrenome");
    Console.WriteLine("\t0. Sair");
}

void ExecutarOpcoes()
{
    Console.Write("ESCOLHA UMA OPÇÃO: ");
    var opcao = Console.ReadLine();
    switch (opcao)
    {
        case "0":
            executar = false;
            break;
        case "1":
            BoasVindas();
            break;
        case "2":
            NomeSobrenome();
            break;
        default:
            Console.WriteLine("Opção Inválida!!");
            break;
    }
}

void BoasVindas()
{
    // Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas
    // personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!
    Console.WriteLine("\nBOAS VINDAS");
    Console.Write("Digite o seu nome: ");
    var nome = Console.ReadLine();
    var mensagem = $"Olá, {nome}! Seja muito bem-vindo!";
    Console.WriteLine(mensagem);

}


void NomeSobrenome()
{
    //Crie um programa que concatene um nome e um sobrenome
    //inseridos pelo usuário e ao final exiba o nome completo.
    Console.WriteLine("\nNOME e SOBRENOME");
    Console.Write("Digite o seu nome: ");
    var nome = Console.ReadLine();
    Console.Write("Digite o seu sobrenome: ");
    var sobrenome = Console.ReadLine();
    StringBuilder stringBuilder = new();
    stringBuilder.Append(nome);
    stringBuilder.Append(' ');
    stringBuilder.Append(sobrenome);
    var mensagem = stringBuilder.ToString();
    Console.WriteLine(mensagem);
}
