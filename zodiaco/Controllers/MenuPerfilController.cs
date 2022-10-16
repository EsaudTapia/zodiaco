using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zodiaco.Models;
using zodiaco.Services;

namespace zodiaco.Controllers
{
    public class MenuPerfilController : Controller
    {
        // GET: Achivo
        public ActionResult RegistroUsuario()
        {

            return View();
        }
        [HttpPost]

        public ActionResult RegistroUsuario(Usuario usuario  )
        {
            var us = new GuardarUsuarioServices();
            var resultado=us.guardarUsuario(usuario);
            ViewBag.resultado = resultado;
            return View();
        }

        // GET: Achivo
        public ActionResult loginUsuario()
        {
            return View();
        }
        [HttpPost]

        public ActionResult loginUsuario(Usuario usuario)
        {
            var lu = new loginServices();
            var resultado = lu.login(usuario);

            if(resultado== "No existe la base de datos")
            {
                ViewBag.resultadoL = "No existe la base de datos";
                return View();
            }
            else if (resultado != "")
            {
                TempData["UserName"] = resultado;
                return RedirectToAction("Perfil", "MenuPerfil");
                

            }else { 
                ViewBag.resultadoL = "Sus usuario o contraseña son incorrectos";
            return View();
        }

        }


        // GET: Achivo
        public ActionResult Perfil()
        {
            var userName = TempData["UserName"].ToString();
            var per = new PerfilServices();
            var model = per.leerPerfil(userName);       
            return View(model);
        }


    }
}
