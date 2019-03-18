using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControl.Models.ViewModels
{
    public class ProdutoViewModel
    {
        public Produto GetProduto { get; set; }
        public List<Fornecedor> GetFornecedores { get; set; }
        public int SelectedFornecedor { get; set; }
        public bool sucess { get; set; }
    }
}
