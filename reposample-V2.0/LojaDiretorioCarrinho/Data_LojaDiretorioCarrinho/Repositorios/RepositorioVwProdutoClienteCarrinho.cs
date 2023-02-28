using Data_LojaDiretorioCarrinho.Models;
using DATA_LojaDiretorioCarrinho.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LojaDiretorioCarrinho.Repositorios
{
    // Classe do Repositório da Relação do Cliente e do Produto, utilizando a Interface e a Base.
    public class RepositorioVwProdutoClienteCarrinho : BaseRepositorio<VwProdutoClienteCarrinho>, IRepositorioVwProdutoClienteCarrinho
    {
        public RepositorioVwProdutoClienteCarrinho(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
