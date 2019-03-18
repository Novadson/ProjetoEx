using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockControl.Models;
using StockControl.Models.ViewModels;
using StockControl.Repositories;
using System.Diagnostics;
//Autor:Novadson Thelus

namespace StockControl.Controllers
{
    public class CadastrosController : Controller
    {
        private readonly ApplicationContext contexto;
        private readonly FornecedorRepository fornecedorRepository;
        private readonly ProdutoRepository produtoRepository;
        private readonly ClienteRepository clienteRepository;
        private readonly FuncionarioRepository funcionarioRepository;
        private readonly VendaRepository vendaRepository;
        private readonly IHttpContextAccessor httpContext;

        public CadastrosController(ApplicationContext contexto,
            FornecedorRepository fornecedorRepository, ProdutoRepository produtoRepository,
            ClienteRepository clienteRepository, FuncionarioRepository funcionarioRepository,
            VendaRepository vendaRepository, IHttpContextAccessor httpContext)
        {
            this.contexto = contexto;
            this.fornecedorRepository = fornecedorRepository;
            this.produtoRepository = produtoRepository;
            this.clienteRepository = clienteRepository;
            this.funcionarioRepository = funcionarioRepository;
            this.vendaRepository = vendaRepository;
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

        /*Inicial Fornecedor*/

        public IActionResult CadFornecedor()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View();

            }
            return RedirectToAction("Login", "Usuario");
        }

        public IActionResult FornecedoresCadastrados()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View(fornecedorRepository.GetFornecedorList());
            }
            return RedirectToAction("Login", "Usuario");

        }


        [HttpPost]
        public IActionResult CadastrarFornecedor(Fornecedor fornecedor, int Id)
        {
            var forne = new Fornecedor();

            if (ModelState.IsValid && Id > 0)
            {
                fornecedorRepository.EditarFornecedor(fornecedor, Id);
            }
            else
            {
                fornecedorRepository.AddFornecedor(fornecedor);
            }

            return RedirectToAction(nameof(FornecedoresCadastrados));
        }

        public IActionResult EditarFornecedor(int Id)
        {
            return View(nameof(CadFornecedor),
                fornecedorRepository.GetFornecedorById(Id));
        }



        public IActionResult DetalhesDoFornecedor(int Id)
        {
            return View(fornecedorRepository.GetFornecedorById(Id));
        }

        public IActionResult ExcluirFornecedor(int Id)
        {
            fornecedorRepository.ExcluirFornecedor(Id);
            return RedirectToAction(nameof(FornecedoresCadastrados));
        }

        /*Fim Fornecedor ↑ */

        [HttpGet]
        public IActionResult CadProduto()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                var produtoViewModel = new ProdutoViewModel()
                {
                    GetFornecedores = fornecedorRepository.GetFornecedorListAtivo()
                };
                return View(produtoViewModel);
            }
            return RedirectToAction("Login", "Usuario");
        }


        [HttpPost]
        public IActionResult CadastrarProduto(ProdutoViewModel model, int Id)
        {
            if (Id > 0)
            {
                produtoRepository.EditarProduto(model, Id);
            }
            else
            {
                produtoRepository.SalvarProduto(model);
            }
            return RedirectToAction(nameof(ProdutosCadastrados));
        }


        public IActionResult ProdutosCadastrados()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View(produtoRepository.GetProdutoList());
            }
            return RedirectToAction("Login", "Usuario");

        }


        public IActionResult EditarProduto(int Id)
        {
            var produto = new ProdutoViewModel()
            {
                GetProduto = produtoRepository.GetProdutoById(Id),
                GetFornecedores = fornecedorRepository.GetFornecedorList()
            };
            return View(nameof(CadProduto), produto);
        }

        public IActionResult ExcluirProduto(int Id)
        {
            produtoRepository.DeleteProduto(Id);
            return RedirectToAction(nameof(ProdutosCadastrados));
        }

        public IActionResult DetalhesDoProduto(int Id)
        {
            return View(produtoRepository.GetProdutoById(Id));
        }

        /*Fim Produto ↑ */

        public IActionResult CadCliente()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Usuario");
        }

        [HttpPost]
        public IActionResult CadastrarCliente(Cliente cliente, int Id)
        {
            if (ModelState.IsValid && Id > 0)
            {
                clienteRepository.EditarCliente(cliente, Id);
            }
            else
            {
                clienteRepository.SalvarCliente(cliente);
            }
            return RedirectToAction(nameof(ClientesCadastrados));
        }


        public IActionResult ExcluirCliente(int Id)
        {
            clienteRepository.ExcluirCliente(Id);
            return RedirectToAction(nameof(ClientesCadastrados));
        }

        public IActionResult EditarCliente(int Id)
        {
            return View(nameof(CadCliente), clienteRepository.GetClienteById(Id));
        }



        public IActionResult ClientesCadastrados()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View(clienteRepository.GetClienteList());
            }
            return RedirectToAction("Login", "Usuario");
        }


        public IActionResult DetalhesDoCliente(int Id)
        {
            return View(clienteRepository.GetClienteById(Id));
        }
        /*Fim Cliente ↑ */

        public IActionResult CadFuncionario()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Usuario");
        }

        [HttpPost]
        public IActionResult CadastrarFuncionario(Funcionario funcionario, int Id)
        {
            if (Id > 0)
            {
                funcionarioRepository.EditarFuncionario(funcionario, Id);
            }
            else
            {
                funcionarioRepository.SalvarFuncionario(funcionario);
            }
            return RedirectToAction(nameof(FuncionariosCadastrados));
        }


        public IActionResult FuncionariosCadastrados()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View(funcionarioRepository.GetFuncionarioList());
            }
            return RedirectToAction("Login", "Usuario");
        }

        public IActionResult EditarFuncionario(int Id)
        {
            return View(nameof(CadFuncionario), funcionarioRepository.GetFuncionarioById(Id));
        }

        public IActionResult DetalhesDoFuncionario(int Id)
        {
            return View(funcionarioRepository.GetFuncionarioById(Id));
        }

        public IActionResult ExcluirFuncionario(int Id)
        {
            funcionarioRepository.ExcluirFuncionario(Id);

            return RedirectToAction(nameof(FuncionariosCadastrados));
        }
        /*Fim Funcionário ↑ */
        public IActionResult SimularPreco()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Usuario");
        }
        [HttpPost]
        public IActionResult SimularPreco(SimularPreco simularPreco)
        {
            var precoV = simularPreco.PrecoCompra + ((simularPreco.PrecoCompra * simularPreco.MargeLucro) / 100);

            var simular = new SimularPreco()
            {
                PrecoCompra = simularPreco.PrecoCompra,
                MargeLucro = simularPreco.MargeLucro,
                PrecoVenda = precoV,
                Lucro = ((simularPreco.PrecoCompra * simularPreco.MargeLucro) / 100),
                MargemBruta = ((simularPreco.MargeLucro / precoV) * 100)
            };
            return View(nameof(ResultadoDaSimulacao), simular);
        }

        public IActionResult ResultadoDaSimulacao()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Usuario");
        }
        /*Fim Simulação de Preço ↑ */


        public IActionResult CadVenda()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                var venda = new VendaViewModel()
                {
                    GetFuncionarios = vendaRepository.GetFuncionarioList(),
                    GetProdutos = vendaRepository.GetProdutoList(),
                    GetClientes = vendaRepository.GetClienteList()
                };
                return View(venda);
            }
            return RedirectToAction("Login", "Usuario");
        }

        [HttpPost]
        public IActionResult CadastrarVenda(VendaViewModel model, int Id)
        {
            if (Id > 0)
            {
                vendaRepository.EditarVendas(model, Id);
            }
            else
            {
                vendaRepository.SalvarVendas(model);
            }
            return RedirectToAction(nameof(VendasCadastradas));
        }

        public IActionResult VendasCadastradas()
        {
            var IdUsuario = HttpContext.Session.GetInt32("IdUsuario");

            if (IdUsuario != null)
            {
                return View(vendaRepository.GetVendaList());
            }
            return RedirectToAction("Login", "Usuario");

        }

        [HttpGet]
        public IActionResult EditarVendas(int Id)
        {
            var viewVenda = new VendaViewModel()
            {
                GetVenda = vendaRepository.GetVendaById(Id),
                GetClientes = vendaRepository.GetClienteList(),
                GetFuncionarios = vendaRepository.GetFuncionarioList(),
                GetProdutos = vendaRepository.GetProdutoList()
            };
            return View(nameof(CadVenda), viewVenda);
        }

        [HttpGet]
        public IActionResult ExcluirVenda(int Id)
        {
            vendaRepository.ExcluirVenda(Id);
            return RedirectToAction(nameof(VendasCadastradas));
        }

        public IActionResult DetalhesDaVenda(int Id)
        {
            return View(vendaRepository.GetVendaById(Id));
        }


        public IActionResult CancelarVenda(int Id)
        {
            vendaRepository.CancelarVenda(Id);
            return RedirectToAction(nameof(VendasCadastradas));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
