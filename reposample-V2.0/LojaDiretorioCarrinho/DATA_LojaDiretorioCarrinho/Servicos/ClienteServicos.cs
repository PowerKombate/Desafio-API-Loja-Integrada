using DATA_LojaDiretorioCarrinho.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_LojaDiretorioCarrinho.Servicos
{
    public class ClienteServicos
    {
        public RepositorioCliente oRepositorioCliente { get; set; }

        public ClienteServicos()
        {
            oRepositorioCliente = new RepositorioCliente();
        }
    }
}
