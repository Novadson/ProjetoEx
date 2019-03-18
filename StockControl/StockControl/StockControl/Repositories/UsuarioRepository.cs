

using StockControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockControl.Repositories
{
    public class UsuarioRepository
    {
        private readonly ApplicationContext contexto;

        public UsuarioRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public Usuario GetUsuarioBiId(int Id)
        {
            return contexto.Set<Usuario>()
                .SingleOrDefault(u => u.Id.Equals(Id));
        }


        internal void SalvarUsuario(Usuario usuario)
        {
            contexto.Set<Usuario>().Add(usuario);
            contexto.SaveChanges();
        }

        internal Usuario AutenticarUsuarioEmail(Usuario usuario)
        {
            return contexto.Set<Usuario>()
                .Where(u => u.Email.Equals(usuario.EmailLogin) && u.Senha.Equals(usuario.Senha)).SingleOrDefault();
        }

        internal Usuario AutenticarUsuarioLogin(Usuario usuario)
        {
            return contexto.Set<Usuario>()
                .Where(u => u.Login.Equals(usuario.EmailLogin) && u.Senha.Equals(usuario.Senha)).SingleOrDefault();
        }



        internal List<Usuario> GetUsuarioList()
        {
            return contexto.Set<Usuario>().OrderBy(u => u.Nome).ToList();
        }

        internal void ExcluirUsuario(int Id)
        {
            contexto.Set<Usuario>().Remove(GetUsuarioBiId(Id));
            contexto.SaveChanges();
        }

        internal void EditarUsuario(Usuario usuario, int Id)
        {
            GetUsuarioBiId(Id).Nome = usuario.Nome;
            GetUsuarioBiId(Id).Celular = usuario.Celular;
            GetUsuarioBiId(Id).Email = usuario.Email;
            GetUsuarioBiId(Id).Senha = usuario.Senha;
            GetUsuarioBiId(Id).Login = usuario.Login;
            GetUsuarioBiId(Id).Status = usuario.Status;
            contexto.SaveChanges();
        }
    }
}

