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
    Console.WriteLine("\t3. Dois Valores");
    Console.WriteLine("\t4. Conta Caracteres");
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
        case "3":
            DoisValores();  
            break;
        case "4":
            ContaCaracteres();
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

void DoisValores()
{
    //3.Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
    //-A soma entre esses dois números;
    //-A subtração entre os dois números;
    //-A multiplicação entre os dois números;
    //-A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
    //-A média entre os dois números.
    Console.WriteLine("\nDOIS VALORES");

    Console.Write("Digite o primeiro valor: ");
    var valorRecebido1 = Console.ReadLine();
    _ = double.TryParse(valorRecebido1, out double valor1);

    Console.Write("Digite o segundo valor: ");
    var valorRecebido2 = Console.ReadLine();    
    _ = double.TryParse(valorRecebido2, out double valor2);

    var soma = valor1 + valor2;
    var subtracao = valor1 - valor2;
    var multiplicacao = valor1 * valor2;
    var divisao = valor2 != 0 ? valor1 / valor2 : 0;
    var media = soma / 2;



    Console.WriteLine($"A soma entre esses dois números: {soma}");
    Console.WriteLine($"A subtração entre os dois números: {subtracao}");
    Console.WriteLine($"A multiplicação entre os dois números: {multiplicacao}");
    Console.WriteLine($"A divisão entre os dois números : {divisao}");
    Console.WriteLine($"A média entre os dois números : {media}");

}

void ContaCaracteres()
{
    // Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres
    // que a palavra inserida tem.
    Console.WriteLine("\nCONTA CARACTERES");
    Console.Write("Digite uma ou mais palavras: ");
    var palavrasRecebidas = Console.ReadLine();
    int quantidadeCaracteres = palavrasRecebidas!.Length;
    Console.WriteLine($"Quantidade de caracteres que a palavra inserida tem: {quantidadeCaracteres}");
}
