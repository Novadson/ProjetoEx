using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockControl.Models;
using StockControl.Repositories;

namespace StockControl.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApplicationContext contexto;
        private readonly UsuarioRepository usuarioRepository;
        private readonly IHttpContextAccessor httpContext;


        public UsuarioController(ApplicationContext contexto,
            UsuarioRepository usuarioRepository, IHttpContextAccessor httpContext)
        {
            this.contexto = contexto;
            this.usuarioRepository = usuarioRepository;
            this.httpContext = httpContext;
        }


        public IActionResult Index()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View();

            }
            return RedirectToAction("Login", "Usuario");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadUsuario()
        {
            return View();
        }

        public IActionResult UsuariosCadastrados()
        {
            var IdUsuario = httpContext.HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View(usuarioRepository.GetUsuarioList());
            }

            return RedirectToAction("Login", "Usuario"); ;
        }


        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CadastrarUsuario(Usuario usuario, int Id)
        {
            if (Id > 0)
            {
                usuarioRepository.EditarUsuario(usuario, Id);
            }
            else
            {
                usuarioRepository.SalvarUsuario(usuario);
            }
            return RedirectToAction(nameof(UsuariosCadastrados));
        }


        public IActionResult EditarUsuario(int Id)
        {
            return View(nameof(CadUsuario), usuarioRepository.GetUsuarioBiId(Id));
        }

        public IActionResult ExcluirUsuario(int Id)
        {
            usuarioRepository.ExcluirUsuario(Id);
            return RedirectToAction(nameof(UsuariosCadastrados));

        }

        public IActionResult DetalhesDoUsuario(int Id)
        {
            return View(usuarioRepository.GetUsuarioBiId(Id));
        }

        [HttpPost]
        public IActionResult LogarSe(Usuario usuario)
        {
            var usuarioBDEmail = usuarioRepository.AutenticarUsuarioEmail(usuario);

            var usuarioBDLogin = usuarioRepository.AutenticarUsuarioLogin(usuario);

            if (usuarioBDEmail != null)
            {
                HttpContext.Session.SetInt32("IdUsuario", usuarioBDEmail.Id);
                return View(nameof(Index), usuarioBDEmail);
            }
            if (usuarioBDLogin != null)
            {
                HttpContext.Session.SetInt32("IdUsuario", usuarioBDLogin.Id);
                return View(nameof(Index), usuarioBDLogin);
            }
            ModelState.AddModelError("EmailLogin", "Email/Login Ou Senha Inexistente.");
            return View(nameof(Login));
        }



        public IActionResult Desconectar()
        {
            HttpContext.Session.Clear();
            return View(nameof(Login));
        }

    }
}