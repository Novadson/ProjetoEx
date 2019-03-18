using System.Collections.Generic;

namespace StockControl.Models.ViewModels
{
    public class VendaViewModel
    {

        public Venda GetVenda { get; set; }

        public List<Produto> GetProdutos { get; set; }
        public int  SelectedProduto { get; set; }
        
        public List<Cliente>GetClientes { get; set; }
        public int SelectedCliente { get; set; } 
        
        public List<Funcionario>GetFuncionarios{ get; set; }
        public int SelectedFuncionario { get; set; }
    }
}
