using System;
using AtividadeFinalPontoDigital.Models;
using AtividadeFinalPontoDigital.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeFinalPontoDigital.Controllers
{
    public class HomeController : Controller
    {
    PlanoRepositorio planoRepositorio = new PlanoRepositorio();
     [HttpGet]   
     public IActionResult Index(){
         ViewData["NomeView"] = "Home - Ponto Digital";
         return View();
     }
     [HttpGet]
     public IActionResult Sobre(){
         ViewData["NomeView"] = "Sobre - Ponto Digital";
         return View();
     }
     public IActionResult Login(){
         ViewData["NomeView"] = "Login - Ponto Digital";
         return View();
     }
     [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {

                // var planos = planoRepositorio.Listar();
                UsuarioModel usuarioCadastrar = new UsuarioModel(
                nome: form["Nome"],
                email: form["Email"],
                dataNascimento:DateTime.Parse(form["DataNascimento"]),
                senha: form["Senha"],
                plano: form["Plano"]
            );
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            usuarioRepositorio.CadastrarUsuario (usuarioCadastrar);

            return RedirectToAction ("Login");
        }
        [HttpGet]
        public IActionResult Cadastro(){
            ViewData["NomeView"] = "Cadastro - Ponto Digital";
            return View();  
        }
        public IActionResult Comentarios(){
        ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        ViewData["comentariosaprovados"] = comentarioRepositorio.ListarAprovados();
        return View();
    }
    }
}