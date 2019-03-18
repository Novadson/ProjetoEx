using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
//Author:NT
namespace StockControl.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }

    public class Produto:BaseModel
    {
        [Required(ErrorMessage ="Código  é obrigatório")]
        public string Codigo { get; set; }

        [Required(ErrorMessage ="Código  é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage ="Código  é obrigatório")]
        public int  EstoqueMinimo  { get; set; }

        [Required(ErrorMessage = "Código  é obrigatório")]
        public int QtdEmEstoque { get; set; }

        [Required(ErrorMessage = "CMV  é obrigatório")]
        public decimal CMV { get; set; }

        [Required(ErrorMessage ="Fornecedor  é obrigatório")]
        public Fornecedor Fornecedor { get; set; }

        [Required(ErrorMessage ="Categoria  é obrigatório")]
        public string Categoria  { get; set; }

    }

    public class Fornecedor : BaseModel
    {
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string Nome { get; set; }


        [Required(ErrorMessage ="Nome é Tipo de Estabelecimento")]
        public string TipoEstabelecimento { get; set; }

        [Required(ErrorMessage ="Nome é Tipo de Estabelecimento")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Nome é Contato")]
        public string Contato { get; set; }

        [Required(ErrorMessage ="Nome é Tipo de Estabelecimento")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Nome é Tipo de Estabelecimento")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Pais é obrigátorio")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "UF é obrigátorio")]
        public string Uf { get; set; }

        [Required(ErrorMessage = "Cidade é obrigátorio")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Bairro é obrigátorio")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Rua é obrigátorio")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Número")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Nome é Tipo de Estabelecimento")]
        public bool Status { get; set; }

        [DataMember]
        public bool sucess;
    }

    public class Cliente:BaseModel
    {
        [Required(ErrorMessage = "Nome é obrigátorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Cpf/Cnpj é obrigátorio")]
        public string CpfCnpj { get; set; }

        [Required(ErrorMessage = "Rg é obrigátorio")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Status é obrigátorio")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Pais é obrigátorio")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "UF é obrigátorio")]
        public string Uf { get; set; }

        [Required(ErrorMessage = "Cidade é obrigátorio")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Bairro é obrigátorio")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Rua é obrigátorio")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Número")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Celular é obrigátorio")]
        public string Celular { get; set; }

        [Required,EmailAddress(ErrorMessage = "Email é obrigátorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Status é obrigátorio")]
        public bool Status { get; set; }
    }


    public class Funcionario : BaseModel
    {
        [Required(ErrorMessage = "Nome é obrigátorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Número de Matrícula é obrigátorio")]
        public int NumeroMatricula { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é obrigátorio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Genero é obrigátorio")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Cpf é obrigátorio")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Rg é obrigátorio")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Email é obrigátorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ocupação é obrigátorio")]
        public string Ocupacao { get; set; }

        [Required(ErrorMessage = "Grau  de Escolaridade é obrigátorio")]
        public string GrauEscolaridade { get; set; }

        [Required(ErrorMessage = "Status é obrigátorio")]
        public bool Status { get; set; }

        [Required(ErrorMessage = "Celular é obrigátorio")]
        public string Celular { get; set; }
    }

    public class Venda:BaseModel
    {
        [Required]
        public Funcionario Funcionario { get; set; }
        [Required]
        public int Comissao { get; set; }
        [Required]
        public Produto Produto{ get; set; }
        [Required]
        public Cliente Cliente { get; set; }
        [DataMember]
        [Required]
        public int Quantidade { get; set; }
        [DataMember]
        public decimal ValorTotal { get; set; }
        [DataMember]
        public decimal PrecoUnitario { get; set; }
        [Required]
        public string Tipo { get; set; }

    }


    public class SimularPreco
    {
        public decimal PrecoCompra { get; set; }
        public int MargeLucro { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal Lucro { get; set; }
        public decimal MargemBruta { get; set; }
    }

    public class Usuario:BaseModel
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }


        public string Email { get; set; }

        [Required(ErrorMessage = "Contato é obrigatório")]
        public string Celular { get; set; }
      
        [Required(ErrorMessage = "Login é obrigatório")]
        public string Login { get; set; }

        public string EmailLogin { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        public string Senha { get; set; }

        public bool Status { get; set; }
    }
}

