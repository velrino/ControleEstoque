﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult GrupoProduto()
        {
            return View();
        }
        // GET: Cadastro
        public ActionResult MarcaProduto()
        {
            return View();
        }
    }
}