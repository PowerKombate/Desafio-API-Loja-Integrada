using DATA_LojaDiretorioCarrinho.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_LojaDiretorioCarrinho.Servicos
{
    public class ProdutoService
    {
        public RepositorioProduto oRepositorioProduto { get; set; }

        public ProdutoService()
        {
            oRepositorioProduto = new RepositorioProduto();
        }
    }
}
