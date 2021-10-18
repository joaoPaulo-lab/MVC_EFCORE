using System;

namespace MVC_EFCORE.Models
{
    public class Livro
    {
        public Livro() =>
            DataEntrada = DateTime.Now;
        public Livro(int iD, int categoriaID, string titulo, string autor, int quantidade, decimal preco, Categoria categoria) : this()
        {
            ID = iD;
            CategoriaID = categoriaID;
            Titulo = titulo;
            Autor = autor;
            Quantidade = quantidade;
            Preco = preco;
            Categoria = categoria;
        }

        public Livro(int iD, int categoriaID, string titulo, string autor, int quantidade, decimal preco, DateTime dataEntrada, Categoria categoria)
        {
            ID = iD;
            CategoriaID = categoriaID;
            Titulo = titulo;
            Autor = autor;
            Quantidade = quantidade;
            Preco = preco;
            DataEntrada = dataEntrada;
            Categoria = categoria;
        }

        public int ID { get; set; }
        public int CategoriaID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataEntrada { get; set; }
        public Categoria Categoria { get; set; }
    }
}
