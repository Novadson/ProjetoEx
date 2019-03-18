using System;
using System.Collections.Generic;
using System.Linq;
using StockControl.Models;

namespace StockControl.Repositories
{
    public class ClienteRepository
    {
        private readonly ApplicationContext contexto;

        public ClienteRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        internal void SalvarCliente(Cliente cliente)
        {
            contexto.Set<Cliente>().Add(cliente);
            contexto.SaveChanges();
        }

        public Cliente GetClienteById(int Id)
        {
            return contexto.Set<Cliente>().SingleOrDefault(c => c.Id.Equals(Id));
        }


        internal List<Cliente> GetClienteList()
        {
            return contexto.Set<Cliente>().ToList();
        }


        internal void ExcluirCliente(int Id)
        {
            contexto.Set<Cliente>().Remove(GetClienteById(Id));
            contexto.SaveChanges();
        }

        internal void EditarCliente(Cliente cliente, int Id)
        {
            GetClienteById(Id).Nome = cliente.Nome;
            GetClienteById(Id).CpfCnpj = cliente.CpfCnpj;
            GetClienteById(Id).Rg = cliente.Rg;
            GetClienteById(Id).Cep = cliente.Cep;
            GetClienteById(Id).Pais = cliente.Pais;
            GetClienteById(Id).Uf = cliente.Uf;
            GetClienteById(Id).Cidade = cliente.Cidade;
            GetClienteById(Id).Bairro = cliente.Bairro;
            GetClienteById(Id).Rua = cliente.Rua;
            GetClienteById(Id).Numero = cliente.Numero;
            GetClienteById(Id).Celular = cliente.Celular;
            GetClienteById(Id).Email = cliente.Email;
            GetClienteById(Id).Status = cliente.Status;
            contexto.SaveChanges();
        }
    }
}
