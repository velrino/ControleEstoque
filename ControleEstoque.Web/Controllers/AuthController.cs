using ControleEstoque.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ControleEstoque.Web.Controllers
{
    public class AuthController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnURL)
        {
            ViewBag.ReturlUrl = returnURL;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Auth login, string returnURL)
        {
            if (!ModelState.IsValid)
                return View(login);

            var user = (login.Usuario == "velrino" && login.Senha == "123");
            
            if(user)
            {
                FormsAuthentication.SetAuthCookie(login.Usuario, login.LembrarMe);

                if (Url.IsLocalUrl(returnURL))
                {
                    return Redirect(returnURL);
                }
                else
                {
                    RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Login ou senha inválido.");
            }
            return View(login);
        }

        [HttpGet]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}