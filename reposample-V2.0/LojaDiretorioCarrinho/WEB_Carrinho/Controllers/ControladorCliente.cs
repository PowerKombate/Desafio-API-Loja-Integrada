using DATA_LojaDiretorioCarrinho.Models;
using DATA_LojaDiretorioCarrinho.Servicos;
using DATA_LojaDiretorioCarrinho.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_Carrinho.Controllers
{
    public class ControladorCliente : Controller
    {
        private ClienteServicos oClienteServicos = new ClienteServicos();
        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteServicos.oRepositorioCliente.SelecionarTodos();
            return View(oListCliente);
        }
    }
}
