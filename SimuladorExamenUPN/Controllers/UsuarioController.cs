using SimuladorExamenUPN.Interfaces;
using SimuladorExamenUPN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SimuladorExamenUPN.Controllers
{
    public class UsuarioController : Controller
    {

        private ISession isesion;

        public UsuarioController(ISession isesion)
        {
            this.isesion = isesion;
        }
        [HttpGet]
        public ActionResult Login()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            
            var usuario = isesion.LogueoUsuario(username, password);
             if (usuario != null)
            {
                FormsAuthentication.SetAuthCookie(username, false);

               return RedirectToAction("Index", "Home");
            }
            ViewBag.Validation = "Usuario y/o contraseña incorrecta";
            return View();
        }


        public ActionResult Logout() {
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}