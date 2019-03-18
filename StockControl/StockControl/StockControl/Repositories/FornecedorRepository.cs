using System;
using System.Collections.Generic;
using System.Linq;
using StockControl.Models;

namespace StockControl.Repositories
{
    public class FornecedorRepository
    {
        private readonly ApplicationContext contexto;

        public FornecedorRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public Fornecedor GetFornecedorById(int Id)
        {
            return contexto.Set<Fornecedor>()
                .SingleOrDefault(f => f.Id.Equals(Id));
        }

    

        internal void AddFornecedor(Fornecedor fornecedor)
        {
            contexto.Set<Fornecedor>().Add(fornecedor);
            contexto.SaveChanges();
        }

        internal List<Fornecedor> GetFornecedorList()
        {
            return contexto.Set<Fornecedor>()
                .OrderBy(f => f.Nome)
                .OrderBy(f => f.Uf)
                .OrderBy(f => f.Cidade).ToList();
        }

        internal List<Fornecedor> GetFornecedorListAtivo()
        {
            return contexto.Set<Fornecedor>().Where(f => f.Status == true).ToList();
        }

        internal void ExcluirFornecedor(int Id)
        {
            contexto.Set<Fornecedor>().Remove(GetFornecedorById(Id));
            contexto.SaveChanges();
        }

        internal void EditarFornecedor(Fornecedor fornecedor, int Id)
        {
            GetFornecedorById(Id).Nome = fornecedor.Nome;
            GetFornecedorById(Id).TipoEstabelecimento = fornecedor.TipoEstabelecimento;
            GetFornecedorById(Id).Cnpj = fornecedor.Cnpj;
            GetFornecedorById(Id).Contato = fornecedor.Contato;
            GetFornecedorById(Id).Email = fornecedor.Email;
            GetFornecedorById(Id).Cidade = fornecedor.Cidade;
            GetFornecedorById(Id).Uf = fornecedor.Uf;
            GetFornecedorById(Id).Rua = fornecedor.Rua;
            GetFornecedorById(Id).Bairro = fornecedor.Bairro;
            GetFornecedorById(Id).Nome = fornecedor.Nome;
            GetFornecedorById(Id).Cep = fornecedor.Cep;
            GetFornecedorById(Id).Pais = fornecedor.Pais;
            GetFornecedorById(Id).Status = fornecedor.Status;
            contexto.SaveChanges();
        }

    }
}
