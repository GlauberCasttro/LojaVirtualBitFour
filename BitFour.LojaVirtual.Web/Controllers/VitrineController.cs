﻿using Bitfour.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BitFour.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorpagina = 3;
        // GET: Produto
        public ActionResult ListaProdutos(int pagina =  1)
        {
            _repositorio = new ProdutosRepositorio();
            //comando take retorna uma quantidade especifica de produtos no caso abaixo 10
            var produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
            .Skip((pagina - 1)* ProdutosPorpagina)
            .Take(ProdutosPorpagina);

            return View(produtos);
        }
    }
}