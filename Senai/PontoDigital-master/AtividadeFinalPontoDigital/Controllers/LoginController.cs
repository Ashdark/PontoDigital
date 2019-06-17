using AtividadeFinalPontoDigital.Models;
using AtividadeFinalPontoDigital.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeFinalPontoDigital.Controllers
{
    public class LoginController : Controller
    {
        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
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
        public IActionResult ComentariosAprovarRecusar(){
        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        ViewData["comentarios"] = comentarioRepositorio.Listar();
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
            UsuarioRepositorio userRepositorio = new UsuarioRepositorio();
            ViewData["usuarios"] = userRepositorio.Listar();
            return View();
        }
        [HttpGet]
        public IActionResult Comentarios(){
        ViewData["comentariosaprovados"] = comentarioRepositorio.ListarAprovados();
        return View();
    }
    [HttpGet]
        public IActionResult VerComentarios(){
        ViewData["comentariosaprovados"] = comentarioRepositorio.ListarAprovados();
        return View();
        }
        [HttpPost]
        public IActionResult Comentar(IFormCollection form){
            ComentarioModel comentario = new ComentarioModel(
                nomecomentario: form["Nomecomentario"],
                comentario: form["Comentario"]
            );
        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        comentarioRepositorio.Cadastrar(comentario);

        return RedirectToAction("Index");
        }
    public IActionResult AprovarComentario(IFormCollection form){
                ComentarioModel comentario = new ComentarioModel(
                nomecomentario: form["Nomecomentario"],
                comentario: form["Comentario"]
            );
     comentarioRepositorio.Aprovar(comentario);

    return RedirectToAction("ComentariosAprovarRecusar");
        }
}
}
