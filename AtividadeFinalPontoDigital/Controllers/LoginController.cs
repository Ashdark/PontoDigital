using AtividadeFinalPontoDigital.Models;
using AtividadeFinalPontoDigital.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeFinalPontoDigital.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult Logar (IFormCollection form) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            if(usuarioRepositorio.BuscarUsuario (form["email"], form["senha"])){
                return RedirectToAction("Logged");
            } else if(usuarioRepositorio.BuscarAdministrador(form["email"], form["senha"])){
                return RedirectToAction("LoggedAdmin");
            } else{
            return RedirectToAction("Login","Home");
            }

    }
    public IActionResult Logged(){
        ViewData["NomeView"] = "Logado!";
        return View();
    }
        public IActionResult Comentarios(){
        ViewData["NomeView"] = "Comentarios - Ponto Digital";
        return View();
    }
        public IActionResult Sobre(){
        ViewData["NomeView"] = "Sobre - Ponto Digital";
        return View();
    }
        public IActionResult Index(){
        ViewData["NomeView"] = "Home - Ponto Digital";
        return View();
    }
            public IActionResult LoggedAdmin(){
            ViewData["NomeView"] = "Administrador na área, hora do ban";
            return View();
        }
}
}