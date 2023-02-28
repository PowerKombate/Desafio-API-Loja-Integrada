using DATA_LojaDiretorioCarrinho.Interfaces;
using DATA_LojaDiretorioCarrinho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LojaDiretorioCarrinho.Repositorios
{
    // Classe do Repositório da Relação do Cliente e do Produto, utilizando a Interface e a Base.
    public class RepositorioProdutoClienteCarrinho : BaseRepositorio<ProdutoClienteCarrinho>, IRepositorioProdutoClienteCarrinho
    {
        public RepositorioProdutoClienteCarrinho(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
