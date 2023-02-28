using DATA_LojaDiretorioCarrinho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LojaDiretorioCarrinho.Interfaces
{
    // Interface para o cliente, utilizando a variável genérica (Referenciando o Modelo).
    public interface IRepositorioCliente : IModeloRepositorio<Cliente>
    {

    }
}
