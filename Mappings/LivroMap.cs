using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_EFCORE.Models;
using System;

namespace MVC_EFCORE.Mappings
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.Property(p => p.Titulo)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(p => p.Autor)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnType("numeric(38,2)")
                .IsRequired();

            builder.HasIndex(p => p.Titulo)
                .HasDatabaseName("IX_Livro_Titulo");

            builder.HasData(
                new Livro(1, 1, "Brilho Eterno de uma mente sem lembranças", "João Paulo", 20, 50.50m),
                new Livro(2, 1, "As crônicas de gelo e fogo", "George R.R. Martin", 20, 50.50m),
                new Livro(3, 1, "Wild Cards", "George R.R. Martin", 20, 50.50m)
                );
        }
    }
}
