using DATA_LojaDiretorioCarrinho.Interfaces;
using DATA_LojaDiretorioCarrinho.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LojaDiretorioCarrinho.Repositorios
{
    // Classe do Repositório do Cliente, utilizando a Interface e a Base.
    public class RepositorioCliente : BaseRepositorio<Cliente>, IRepositorioCliente
    {
        public RepositorioCliente(bool SaveChanges = true) : base(SaveChanges) 
        { 

        }
    }
}
