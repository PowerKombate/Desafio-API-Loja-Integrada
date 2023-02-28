using Data_LojaDiretorioCarrinho.Models;
using DATA_LojaDiretorioCarrinho.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LojaDiretorioCarrinho.Repositorios
{
    // Classe do Repositório do Produto, utilizando a Interface e a Base.
    public class RepositorioProduto : BaseRepositorio<Produto>, IRepositorioProduto
    {
        public RepositorioProduto(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
