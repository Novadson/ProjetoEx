using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockControl.Models;

namespace StockControl.Repositories
{
    public class FuncionarioRepository
    {
        private readonly ApplicationContext contexto;

        public FuncionarioRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public Funcionario GetFuncionarioById(int Id)
        {
            return contexto.Set<Funcionario>().SingleOrDefault(f => f.Id.Equals(Id));
        }

        internal List<Funcionario> GetFuncionarioList()
        {
            return contexto.Set<Funcionario>().ToList();
        }

        internal void SalvarFuncionario(Funcionario funcionario)
        {
            contexto.Set<Funcionario>().Add(funcionario);
            contexto.SaveChanges();
        }

        internal void EditarFuncionario(Funcionario funcionario, int Id)
        {
            GetFuncionarioById(Id).Nome = funcionario.Nome;
            GetFuncionarioById(Id).NumeroMatricula = funcionario.NumeroMatricula;
            GetFuncionarioById(Id).DataNascimento = funcionario.DataNascimento;
            GetFuncionarioById(Id).Genero = funcionario.Genero;
            GetFuncionarioById(Id).Cpf = funcionario.Cpf;
            GetFuncionarioById(Id).Rg = funcionario.Rg;
            GetFuncionarioById(Id).Email = funcionario.Email;
            GetFuncionarioById(Id).Ocupacao = funcionario.Ocupacao;
            GetFuncionarioById(Id).GrauEscolaridade = funcionario.GrauEscolaridade;
            GetFuncionarioById(Id).Celular = funcionario.Celular;
            GetFuncionarioById(Id).Status = funcionario.Status;
            contexto.SaveChanges();
        }

        internal void ExcluirFuncionario(int Id)
        {
            contexto.Set<Funcionario>().Remove(GetFuncionarioById(Id));
            contexto.SaveChanges();
        }

    }
}
