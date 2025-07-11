using Zuplae.Aulas.Atv0012.ConsoleApp;

Console.WriteLine("=========  Sistema de cadatro da Atividade 0012 =========");

Console.WriteLine("Escolha uma das opções do menu abaixo: ");
Console.WriteLine("\t1-Endereço");
Console.WriteLine("\t2-Fornedor");
Console.WriteLine("\t3-Produto");
Console.WriteLine("\t4-Sair");

Console.Write("Digite a opção: ");
int opcao = Convert.ToInt32( Console.ReadLine() );

switch (opcao)
{
	case 1:
		TelaEndereco telaEndereco = new TelaEndereco();
        telaEndereco.ExecutarMenu();
        break;
	case 2:
		Console.WriteLine("Você escolheu Fornecedor.");
		// Aqui você pode adicionar a lógica para manipular Fornecedor
	break;
	case 3:
		Console.WriteLine("Você escolheu Produto.");
        // Aqui você pode adicionar a lógica para manipular Produto
        break;
    case 4:
        Console.WriteLine("Você escolheu Sair.");
        // Aqui você pode adicionar a lógica para manipular Sair
        break;
    default:
        Console.WriteLine("Opção Inválida");
		break;
}