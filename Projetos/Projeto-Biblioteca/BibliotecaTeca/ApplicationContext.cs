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
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Aluguel> Aluguel { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Cliente>().HasKey(t => t.Id);
            modelBuilder.Entity<Cliente>().HasMany(c => c.Alugueis).WithOne(c => c.Cliente);

            modelBuilder.Entity<Aluguel>().HasKey(t => t.Id);
            modelBuilder.Entity<Aluguel>().HasOne(t => t.Cliente);
            modelBuilder.Entity<Aluguel>().HasMany(a => a.Pedidos).WithOne(a => a.Aluguel);
                    
            modelBuilder.Entity<Livro>().HasKey(t => t.Id);
            modelBuilder.Entity<Livro>().HasMany(l => l.Pedidos).WithOne(l=> l.Livro);

            modelBuilder.Entity<Pedido>().HasKey(t => t.Id);
            modelBuilder.Entity<Pedido>().HasOne(t => t.Livro);
            modelBuilder.Entity<Pedido>().HasOne(t => t.Aluguel);
        }
    }
}
