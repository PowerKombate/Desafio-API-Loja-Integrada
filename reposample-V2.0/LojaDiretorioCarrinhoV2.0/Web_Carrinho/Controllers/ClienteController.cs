using DATA_LojaDiretorioCarrinho.Servicos;
using DATA_LojaDiretorioCarrinho.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_LojaDiretorioCarrinho.Models;

namespace WEB_Carrinho.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService oClienteServico = new();
        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteServico.oRepositorioCliente.SelecionarTodos();
            return View(oListCliente);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oClienteServico.oRepositorioCliente.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Cliente oCliente= oClienteServico.oRepositorioCliente.SelecionarPk(id);
            return View(oCliente);
        }

        public IActionResult Edit(int id)
        {
            Cliente oCliente = oClienteServico.oRepositorioCliente.SelecionarPk(id);
            return View(oCliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente model)
        {
            Cliente oCliente = oClienteServico.oRepositorioCliente.Alterar(model);

            int id = oCliente.Id;

            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            oClienteServico.oRepositorioCliente.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
