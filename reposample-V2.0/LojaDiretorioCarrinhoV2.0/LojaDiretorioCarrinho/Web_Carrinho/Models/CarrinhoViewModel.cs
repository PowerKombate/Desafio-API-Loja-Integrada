using Data_LojaDiretorioCarrinho.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Web_Carrinho.Models
{
    public class CarrinhoViewModel
    {
        public Produto oProduto { get; set; }
        public Cliente oCliente { get; set; }

        public int IdProduto { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataCompra { get; set; }
        public double? Frete { get; set; }

        public List<Cliente> oListCliente { get; set; }
        public List<Produto> oListProduto { get; set; }

    }
}
