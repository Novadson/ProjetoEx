﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockControl;

namespace StockControl.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190307233426_statusCliente")]
    partial class statusCliente
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

                    b.Property<string>("Complemento");

                    b.Property<string>("CpfCnpj")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

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

            modelBuilder.Entity("StockControl.Models.Produto", b =>
                {
                    b.HasOne("StockControl.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
