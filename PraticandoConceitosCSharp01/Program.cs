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
    Console.WriteLine("\t0. Sair");
}

void ExecutarOpcoes()
{
    Console.Write("ESCOLHA UMA OPÇÃO: ");
    string? opcao = Console.ReadLine();
    switch (opcao)
    {
        case "0":
            executar = false;
            break;
        case "1":
            BoasVindas();
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
    string nome = Console.ReadLine();
    string mensagem = $"Olá, {nome}! Seja muito bem-vindo!";
    Console.WriteLine(mensagem);

}