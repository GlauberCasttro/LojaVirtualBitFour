using Bitfour.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitFour.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutosRepositorio _repositorio;
        // GET: Produto
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            //comando take retorna uma quantidade especifica de produtos no caso abaixo 10
            var produtos = _repositorio.Produtos.Take(10); 

            return View(produtos);
        }
    }
}