using LibraryManagerMetodoDotNet.Infrastructure;
using LibraryManagerMetodoDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMetodoDotNet.Services
{
    public class LivroService
    {
        private readonly AppDbContext _context;

        public LivroService(AppDbContext context)
        {
            _context = context;
        }

        // Criar um livro
        public void CriarLivro(string titulo, string autor, string anoPublicacao)
        {
            var livro = new Livro
            {
                Titulo = titulo,
                Autor = autor,
                AnoPublicacao = anoPublicacao
            };
            _context.Livros.Add(livro);
            _context.SaveChanges();
            Console.WriteLine("Livro adicionado com sucesso!");
        }

        // Listar todos os livros
        public void ListarLivros()
        {
            var livros = _context.Livros.ToList();
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro encontrado.");
            }
            else
            {
                foreach (var livro in livros)
                {
                    Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.AnoPublicacao}");
                }
            }
        }

        // Atualizar um livro
        public void AtualizarLivro(int id, string titulo, string autor, string anoPublicacao)
        {
            var livro = _context.Livros.FirstOrDefault(l => l.Id == id);
            if (livro == null)
            {
                Console.WriteLine("Livro não encontrado!");
                return;
            }

            livro.Titulo = titulo;
            livro.Autor = autor;
            livro.AnoPublicacao = anoPublicacao;
            _context.SaveChanges();
            Console.WriteLine("Livro atualizado com sucesso!");
        }

        // Deletar um livro
        public void DeletarLivro(string id)
        {
            var livro = _context.Livros.FirstOrDefault(l => l.Id == int.Parse(id));
            if (livro == null)
            {
                Console.WriteLine("Livro não encontrado!");
                return;
            }

            _context.Livros.Remove(livro);
            _context.SaveChanges();
            Console.WriteLine("Livro deletado com sucesso!");
        }
    }
}
