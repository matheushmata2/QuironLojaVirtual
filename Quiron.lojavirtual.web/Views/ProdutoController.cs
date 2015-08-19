using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.lojavirtual.web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoRepositorio _repositorio;

        // GET: Produto
        public ActionResult Index()
        {

            _repositorio = new ProdutoRepositorio();
            var produtos = _repositorio.Produtos.Take(10);
            return View(produtos);
        }
    }
}