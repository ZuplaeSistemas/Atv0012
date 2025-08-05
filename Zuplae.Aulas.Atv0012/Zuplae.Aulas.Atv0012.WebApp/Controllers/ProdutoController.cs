using Microsoft.AspNetCore.Mvc;

namespace Zuplae.Aulas.Atv0012.WebApp.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
