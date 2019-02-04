using BibliotecaTeca.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaTeca
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Livro>().HasKey(t => t.Id);


            modelBuilder.Entity<Cliente>().HasKey(t => t.Id);
            modelBuilder.Entity<Cliente>().HasMany(c => c.Alugueis).WithOne(c => c.Cliente);

            modelBuilder.Entity<Aluguel>().HasKey(t => t.Id);
            modelBuilder.Entity<Aluguel>().HasOne(t => t.Cliente);
            modelBuilder.Entity<Aluguel>().HasMany(a => a.Pedidos).WithOne(a => a.Aluguel);
            

            modelBuilder.Entity<Pedido>().HasKey(t => t.Id);
            modelBuilder.Entity<Pedido>().HasOne(t => t.Aluguel);
            modelBuilder.Entity<Pedido>().HasMany(p => p.Livros).WithOne(p => p.Pedido);
        }
        public DbSet<BibliotecaTeca.Models.Livro> Livro { get; set; }
    }
}
