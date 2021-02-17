using Microsoft.AspNetCore.Mvc;
using Tarefa2.Models;
using Tarefa2.Services;

namespace Tarefa2.Controllers
{
    public class HomeController : Controller
    {
        private ArvoreService _arvoreService = new ArvoreService();

        public IActionResult Index()
        {
            return View();
        }    
        
        public IActionResult GerarArvore(string entrada)
        {
            int[] arrayInteiros = _arvoreService.TransformarParaArrayInteiro(entrada);

            Galho raiz = _arvoreService.GerarArvore(arrayInteiros);

            return PartialView("_Arvore",raiz);
        }
    }
}
