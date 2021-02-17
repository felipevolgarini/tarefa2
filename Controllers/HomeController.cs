using Microsoft.AspNetCore.Mvc;

namespace Tarefa2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }        
    }
}
