using Microsoft.AspNetCore.Mvc;

namespace AtividadeFinalPontoDigital.Controllers
{
    public class HomeController : Controller
    {
     [HttpGet]   
     public IActionResult Index(){
         return View();
     }
    }
}