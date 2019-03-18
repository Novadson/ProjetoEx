using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockControl.Models;
using StockControl.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockControl.Repositories
{
    public class VendaRepository
    {
        private readonly ApplicationContext contexto;

        public VendaRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }


        internal Venda GetVendaById(int Id)
        {
            return contexto.Set<Venda>()
                .Include(v => v.Produto).Include(v => v.Cliente)
                .Include(v => v.Funcionario)
                .Where(c => c.Id.Equals(Id))
                .SingleOrDefault();
        }




        internal Produto GetProdutoById(VendaViewModel model)
        {
            return contexto.Set<Produto>()
                .Where(c => c.Id.Equals(model.SelectedProduto))
                .SingleOrDefault();
        }

        internal Produto GetProdutoPorVenda(int Id)
        {
            return contexto.Set<Produto>()
                .Where(c => c.Id.Equals(GetVendaById(Id).Produto.Id))
                .SingleOrDefault();
        }

        internal Cliente GetClienteById(VendaViewModel model)
        {
            return contexto.Set<Cliente>().SingleOrDefault(c => c.Id.Equals(model.SelectedCliente));
        }

        internal Funcionario GetFuncionarioById(VendaViewModel model)
        {
            return contexto.Set<Funcionario>().SingleOrDefault(c => c.Id.Equals(model.SelectedFuncionario));
        }

        public List<Funcionario> GetFuncionarioList()
        {
            return contexto.Set<Funcionario>().Where(f => f.Ocupacao.Equals("Vendedor")).ToList();
        }

        public List<Produto> GetProdutoList()
        {
            return contexto.Set<Produto>().Include(p => p.Fornecedor).ToList();
        }

        internal List<Cliente> GetClienteList()
        {
            return contexto.Set<Cliente>().Where(c => c.Status.Equals(true)).ToList();
        }

        internal void SalvarVendas(VendaViewModel model)
        {
            if (GetProdutoById(model).EstoqueMinimo <= 10 && model.GetVenda.Quantidade <= GetProdutoById(model).QtdEmEstoque)
            {
                GetProdutoById(model).QtdEmEstoque -= model.GetVenda.Quantidade;
            }
            var vendas = new Venda()
            {
                Comissao = model.GetVenda.Comissao,
                Tipo = model.GetVenda.Tipo,
                Quantidade = model.GetVenda.Quantidade,
                PrecoUnitario = GetProdutoById(model).CMV,
                ValorTotal = GetProdutoById(model).CMV * model.GetVenda.Quantidade,
                Produto = GetProdutoById(model),
                Cliente = GetClienteById(model),
                Funcionario = GetFuncionarioById(model),
            };
            contexto.Set<Venda>().Add(vendas);
            contexto.SaveChanges();
        }

        internal List<Venda> GetVendaList()
        {
            return contexto.Set<Venda>()
                .Include(v => v.Produto).Include(v => v.Cliente).Include(v => v.Funcionario).ToList();
        }

        internal void ExcluirVenda(int Id)
        {
            contexto.Set<Venda>().Remove(GetVendaById(Id));
            contexto.SaveChanges();
        }

        internal void EditarVendas(VendaViewModel model, int Id)
        {
            if (GetProdutoById(model).EstoqueMinimo <= 10 && model.GetVenda.Quantidade <= GetProdutoById(model).QtdEmEstoque)
            {
                if (GetVendaById(Id).Quantidade > model.GetVenda.Quantidade)
                {
                    GetProdutoById(model).QtdEmEstoque -= model.GetVenda.Quantidade - GetVendaById(Id).Quantidade;
                }
                if (GetVendaById(Id).Quantidade < model.GetVenda.Quantidade)
                {
                    GetProdutoById(model).QtdEmEstoque += GetVendaById(Id).Quantidade - model.GetVenda.Quantidade;
                }
            }
            GetVendaById(Id).Comissao = model.GetVenda.Comissao;
            GetVendaById(Id).Tipo = model.GetVenda.Tipo;
            GetVendaById(Id).Quantidade = model.GetVenda.Quantidade;
            GetVendaById(Id).Cliente = GetClienteById(model);
            GetVendaById(Id).Funcionario = GetFuncionarioById(model);
            GetVendaById(Id).Produto = GetProdutoById(model);
            GetVendaById(Id).PrecoUnitario = GetProdutoById(model).CMV;
            GetVendaById(Id).ValorTotal = GetProdutoById(model).CMV * model.GetVenda.Quantidade;
            contexto.SaveChanges();
        }

        internal void CancelarVenda(int Id)
        {
            GetProdutoPorVenda(Id).QtdEmEstoque += GetVendaById(Id).Quantidade;
            GetVendaById(Id).Quantidade = 0;
            GetVendaById(Id).PrecoUnitario = 0;
            GetVendaById(Id).ValorTotal = 0;
            contexto.SaveChanges();
        }

    }
}
