﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockControl;

namespace StockControl.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190317215134_EmailLogin")]
    partial class EmailLogin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockControl.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired();

                    b.Property<string>("Celular")
                        .IsRequired();

                    b.Property<string>("Cep")
                        .IsRequired();

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<string>("CpfCnpj")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Numero");

                    b.Property<string>("Pais")
                        .IsRequired();

                    b.Property<string>("Rg")
                        .IsRequired();

                    b.Property<string>("Rua")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.Property<string>("Uf")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("StockControl.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .IsRequired();

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<string>("Cnpj")
                        .IsRequired();

                    b.Property<string>("Contato")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Endereco")
                        .IsRequired();

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.Property<string>("TipoEstabelecimento")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("StockControl.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .IsRequired();

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Genero")
                        .IsRequired();

                    b.Property<string>("GrauEscolaridade")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("NumeroMatricula");

                    b.Property<string>("Ocupacao")
                        .IsRequired();

                    b.Property<string>("Rg")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("StockControl.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CMV");

                    b.Property<string>("Categoria")
                        .IsRequired();

                    b.Property<string>("Codigo")
                        .IsRequired();

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int>("EstoqueMinimo");

                    b.Property<int>("FornecedorId");

                    b.Property<int>("QtdEmEstoque");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("StockControl.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("EmailLogin");

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("StockControl.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId");

                    b.Property<int>("Comissao");

                    b.Property<int>("FuncionarioId");

                    b.Property<decimal>("PrecoUnitario");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.Property<string>("Tipo")
                        .IsRequired();

                    b.Property<decimal>("ValorTotal");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("StockControl.Models.Produto", b =>
                {
                    b.HasOne("StockControl.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StockControl.Models.Venda", b =>
                {
                    b.HasOne("StockControl.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StockControl.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StockControl.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
