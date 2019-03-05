﻿// <auto-generated />
using System;
using BibliotecaTeca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BibliotecaTeca.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190207230214_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BibliotecaTeca.Models.Aluguel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClienteId");

                    b.Property<DateTime>("DataAluguel");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Aluguel");
                });

            modelBuilder.Entity("BibliotecaTeca.Models.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("BibliotecaTeca.Models.Livro", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPostagem");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<decimal>("Preco");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("BibliotecaTeca.Models.Pedido", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AluguelId");

                    b.Property<long>("LivroId");

                    b.HasKey("Id");

                    b.HasIndex("AluguelId");

                    b.HasIndex("LivroId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("BibliotecaTeca.Models.Aluguel", b =>
                {
                    b.HasOne("BibliotecaTeca.Models.Cliente", "Cliente")
                        .WithMany("Alugueis")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BibliotecaTeca.Models.Pedido", b =>
                {
                    b.HasOne("BibliotecaTeca.Models.Aluguel", "Aluguel")
                        .WithMany("Pedidos")
                        .HasForeignKey("AluguelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BibliotecaTeca.Models.Livro", "Livro")
                        .WithMany("Pedidos")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
