using LibraryManagerMetodoDotNet.Commands;
using LibraryManagerMetodoDotNet.Infrastructure;
using LibraryManagerMetodoDotNet.Services;

using (var context = new AppDbContext())
{
    var livroService = new LivroService(context);

    // Exibe o menu até o usuário escolher sair
    bool sair = false;
    while (!sair)
    {
        Console.Clear();
        Console.WriteLine("----- Menu -----");
        Console.WriteLine("1. Adicionar Livro");
        Console.WriteLine("2. Listar Livros");
        Console.WriteLine("3. Atualizar Livro");
        Console.WriteLine("4. Deletar Livro");
        Console.WriteLine("5. Sair");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                LivroCommand.AdicionarLivro(livroService);
                break;
            case "2":
                LivroCommand.ListarLivros(livroService);
                break;
            case "3":
                LivroCommand.AtualizarLivro(livroService);
                break;
            case "4":
                LivroCommand.DeletarLivro(livroService);
                break;
            case "5":
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        if (!sair)
        {
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}