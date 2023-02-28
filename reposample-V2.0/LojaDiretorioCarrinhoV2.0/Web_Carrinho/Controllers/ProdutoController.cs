using DATA_LojaDiretorioCarrinho.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_LojaDiretorioCarrinho.Models;
using Data_LojaDiretorioCarrinho.Servicos;

namespace WEB_Carrinho.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoService oProdutoServico = new();
        public IActionResult Index()
        {
            List<Produto> oListProduto = oProdutoServico.oRepositorioProduto.SelecionarTodos();
            return View(oListProduto);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oProdutoServico.oRepositorioProduto.Incluir(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Produto oProduto = oProdutoServico.oRepositorioProduto.SelecionarPk(id);
            return View(oProduto);
        }

        public IActionResult Edit(int id)
        {
            Produto oProduto = oProdutoServico.oRepositorioProduto.SelecionarPk(id);
            return View(oProduto);
        }

        [HttpPost]
        public IActionResult Edit(Produto model)
        {
            Produto oProduto = oProdutoServico.oRepositorioProduto.Alterar(model);

            int id = oProduto.Id;

            return RedirectToAction("Details", new { id });
        }

        public IActionResult Delete(int id)
        {
            oProdutoServico.oRepositorioProduto.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
