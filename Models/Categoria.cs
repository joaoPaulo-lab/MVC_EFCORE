using System;
using System.Collections.Generic;

namespace MVC_EFCORE.Models
{
    public class Categoria
    {
        public Categoria(int id, string nome)
        {
            ID = id;
            Nome = nome;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}
