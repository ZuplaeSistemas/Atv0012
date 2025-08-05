using Microsoft.AspNetCore.Mvc;
using Zuplae.Aulas.Atv0012.Models;
using Zuplae.Aulas.Atv0012.Services;

namespace Zuplae.Aulas.Atv0012.WebApp.Controllers
{
    public class EnderecoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Endereco model) // Auto Binding do Model 
        {
            EnderecoService service =  new EnderecoService();            
            int id = service.Cadastrar(model);
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            EnderecoService service = new EnderecoService();
            return View(service.Listar());
        }
    }
}
