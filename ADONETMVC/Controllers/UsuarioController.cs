using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADONETMVC.Repositories;
using ADONETMVC.Models;

namespace ADONETMVC.Controllers
{
    public class UsuarioController : Controller
    {
        public UsuarioRepository usuarioRepository { get; set; }

        public UsuarioController()
        {
            usuarioRepository = new UsuarioRepository();
        }
        // GET: Usuario
        public ActionResult Index()
        {
            List<Usuario> usuarios = usuarioRepository.GetAll();
            return View("Index",usuarios);
        }

        public ActionResult Create()
        {
            return View("Nuevo");
        }

        [HttpPost]
        public ActionResult Store(Usuario usuario)
        {
            return RedirectToAction("Index","Usuario");
        }
    }
}