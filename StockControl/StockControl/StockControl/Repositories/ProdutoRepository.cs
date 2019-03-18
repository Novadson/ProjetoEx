using Microsoft.EntityFrameworkCore;
using StockControl.Models;
using StockControl.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockControl.Repositories
{
    public class ProdutoRepository
    {
        private readonly ApplicationContext contexto;

        public ProdutoRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public List<Produto> GetProdutoList()
        {
            return contexto.Set<Produto>().Include(p => p.Fornecedor).ToList();
        }

        public Fornecedor GetFornecedorById(ProdutoViewModel model)
        {
            return contexto.Set<Fornecedor>()
                .Where(f => f.Id.Equals(model.SelectedFornecedor))
                .SingleOrDefault();
               
        }


        public Produto GetProdutoById(int Id)
        {
            return contexto.Set<Produto>().Include( p => p.Fornecedor)
                .SingleOrDefault(p => p.Id.Equals(Id));
        }

        internal void SalvarProduto(ProdutoViewModel model)
        {
            var produto = new Produto()
            {
                Categoria = model.GetProduto.Categoria,
                Descricao = model.GetProduto.Descricao,
                Codigo = model.GetProduto.Codigo,
                EstoqueMinimo = model.GetProduto.EstoqueMinimo,
                QtdEmEstoque = model.GetProduto.QtdEmEstoque,
                CMV = model.GetProduto.CMV,
                Fornecedor = GetFornecedorById(model)
            };
            contexto.Set<Produto>().Add(produto);
            contexto.SaveChanges();
        }

        internal void DeleteProduto(int Id)
        {
            contexto.Set<Produto>().Remove(GetProdutoById(Id));
            contexto.SaveChanges();
        }

        internal void EditarProduto(ProdutoViewModel model, int Id)
        {
            GetProdutoById(Id).Codigo = model.GetProduto.Codigo;
            GetProdutoById(Id).Descricao = model.GetProduto.Descricao;
            GetProdutoById(Id).Categoria = model.GetProduto.Categoria;
            GetProdutoById(Id).CMV = model.GetProduto.CMV;
            GetProdutoById(Id).EstoqueMinimo = model.GetProduto.EstoqueMinimo;
            GetProdutoById(Id).QtdEmEstoque = model.GetProduto.QtdEmEstoque;
            GetProdutoById(Id).Fornecedor = GetFornecedorById(model);
            contexto.SaveChanges();
            
        }
    }
}
