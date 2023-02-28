using Data_LojaDiretorioCarrinho.Models;
using Data_LojaDiretorioCarrinho.Servicos;
using Microsoft.AspNetCore.Mvc;
using Web_Carrinho.Models;

namespace Web_Carrinho.Controllers
{
    public class CarrinhoController : Controller
    {
        private ProdutoClienteCarrinhoService _service = new ProdutoClienteCarrinhoService();
        public IActionResult Index()
        {
            List<VwProdutoClienteCarrinho> oListVwProdutoClienteCarrinho = _service.oRepositorioVwProdutoClienteCarrinho.SelecionarTodos();
            return View(oListVwProdutoClienteCarrinho);
        }

        public IActionResult Create()
        {
            CarrinhoViewModel oCarrinhoViewModel = new CarrinhoViewModel();
            List<Produto> oListProduto = _service.oRepositorioProduto.SelecionarTodos();
            List<Cliente> oListCliente = _service.oRepositorioCliente.SelecionarTodos();

            oCarrinhoViewModel.oListCliente = oListCliente;
            oCarrinhoViewModel.oListProduto = oListProduto;

            oCarrinhoViewModel.DataCompra = DateTime.Now;
            oCarrinhoViewModel.Frete = 0;

            return View(oCarrinhoViewModel);
        }

        [HttpPost]
        public IActionResult Create(CarrinhoViewModel oCarrinhoViewModel)
        {
            ProdutoClienteCarrinho oProdutoClienteCarrinho = new ProdutoClienteCarrinho();
            oProdutoClienteCarrinho.DataCompra = oCarrinhoViewModel.DataCompra;
            oProdutoClienteCarrinho.Frete = oCarrinhoViewModel.Frete;
            oProdutoClienteCarrinho.IdCliente = oCarrinhoViewModel.IdCliente;
            oProdutoClienteCarrinho.IdProduto = oCarrinhoViewModel.IdProduto;
            

            if(!ModelState.IsValid)
            {
                return View();
            }

            _service.oRepositorioProdutoClienteCarrinho.Incluir(oProdutoClienteCarrinho);

            return RedirectToAction("Index");
        }
    }
}
