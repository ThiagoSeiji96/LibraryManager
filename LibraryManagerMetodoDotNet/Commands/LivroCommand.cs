using LibraryManagerMetodoDotNet.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMetodoDotNet.Commands
{
    public static class LivroCommand
    {
        public static void AdicionarLivro(LivroService livroService)
        {
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            string anoPublicacao = Console.ReadLine();

            livroService.CriarLivro(titulo, autor, anoPublicacao);
        }

        public static void AtualizarLivro(LivroService livroService)
        {
            Console.Write("Digite o ID do livro que deseja atualizar: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Digite o novo título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o novo autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o novo ano de publicação: ");
            string anoPublicacao = Console.ReadLine();

            livroService.AtualizarLivro(id, titulo, autor, anoPublicacao);
        }

        public static void DeletarLivro(LivroService livroService)
        {
            Console.Write("Digite o ID do livro que deseja deletar: ");
            string id = Console.ReadLine();

            livroService.DeletarLivro(id);
        }

        public static void ListarLivros(LivroService livroService)
        {
            livroService.ListarLivros();
        }
    }
}
