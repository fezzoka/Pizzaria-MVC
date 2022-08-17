﻿// <auto-generated />
using System;
using AtividadePizzaria.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Pizzaria_MVC.Migrations
{
    [DbContext(typeof(PizzariaDbContext))]
    partial class PizzariaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pizzaria_MVC.Models.Pizza", b =>
                {
                    b.Property<int>("TamanhoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TamanhoId1")
                        .HasColumnType("int");

                    b.HasKey("TamanhoId");

                    b.HasIndex("TamanhoId1");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("Pizzaria_MVC.Models.PizzaSabor", b =>
                {
                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.Property<int>("SaborId")
                        .HasColumnType("int");

                    b.HasKey("PizzaId", "SaborId");

                    b.HasIndex("SaborId");

                    b.ToTable("PizzasSabores");
                });

            modelBuilder.Entity("Pizzaria_MVC.Models.Sabor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sabores");
                });

            modelBuilder.Entity("Pizzaria_MVC.Models.Tamanho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tamanhos");
                });

            modelBuilder.Entity("Pizzaria_MVC.Models.Pizza", b =>
                {
                    b.HasOne("Pizzaria_MVC.Models.Tamanho", "Tamanho")
                        .WithMany("Pizzas")
                        .HasForeignKey("TamanhoId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tamanho");
                });

            modelBuilder.Entity("Pizzaria_MVC.Models.PizzaSabor", b =>
                {
                    b.HasOne("Pizzaria_MVC.Models.Pizza", "Pizza")
                        .WithMany("PizzasSabores")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pizzaria_MVC.Models.Sabor", "Sabor")
                        .WithMany("PizzasSabores")
                        .HasForeignKey("SaborId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pizza");

                    b.Navigation("Sabor");
                });

            modelBuilder.Entity("Pizzaria_MVC.Models.Pizza", b =>
                {
                    b.Navigation("PizzasSabores");
                });

            modelBuilder.Entity("Pizzaria_MVC.Models.Sabor", b =>
                {
                    b.Navigation("PizzasSabores");
                });

            modelBuilder.Entity("Pizzaria_MVC.Models.Tamanho", b =>
                {
                    b.Navigation("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
