using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class CadastroController : Controller
    {
        [Authorize]
        public ActionResult GrupoProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult MarcaProduto()
        {
            return View();
        }
    }
}