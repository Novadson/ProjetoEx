using Microsoft.EntityFrameworkCore;
using StockControl.Models;
using System;

namespace StockControl
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Fornecedor>().HasKey(f => f.Id);
            modelBuilder.Entity<Produto>().HasOne(f => f.Fornecedor);
            modelBuilder.Entity<Produto>().HasKey(f => f.Id);
            modelBuilder.Entity<Cliente>().HasKey(f => f.Id);
            modelBuilder.Entity<Funcionario>().HasKey(f => f.Id);
            modelBuilder.Entity<Venda>().HasKey(f => f.Id);
            modelBuilder.Entity<Usuario>().HasKey(f => f.Id);
        }
    }
}
