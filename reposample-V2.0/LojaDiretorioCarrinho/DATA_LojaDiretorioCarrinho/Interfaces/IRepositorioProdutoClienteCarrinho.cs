using DATA_LojaDiretorioCarrinho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LojaDiretorioCarrinho.Interfaces
{
    // Interface do Relacionamento do Produto com o Cliente, utilizando a variável genérica (Referenciando o Modelo).
    public interface IRepositorioProdutoClienteCarrinho : IModeloRepositorio<ProdutoClienteCarrinho>
    {

    }
}
