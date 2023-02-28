using DATA_LojaDiretorioCarrinho.Interfaces;
using DATA_LojaDiretorioCarrinho.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_LojaDiretorioCarrinho.Servicos
{
    public class ProdutoClienteCarrinhoService
    {
        public RepositorioVwProdutoClienteCarrinho oRepositorioVwProdutoClienteCarrinho { get; set; }
        public RepositorioProduto oRepositorioProduto { get; set; }
        public RepositorioCliente oRepositorioCliente { get; set; }
        public RepositorioProdutoClienteCarrinho oRepositorioProdutoClienteCarrinho { get; set; }


        public ProdutoClienteCarrinhoService()
        {
            oRepositorioVwProdutoClienteCarrinho = new RepositorioVwProdutoClienteCarrinho();
            oRepositorioCliente = new RepositorioCliente();
            oRepositorioProduto = new RepositorioProduto();
            oRepositorioProdutoClienteCarrinho = new RepositorioProdutoClienteCarrinho();
        }
    }
}