using Microsoft.AspNetCore.Mvc;
using PrimeiroSite.Models;
using PrimeiroSite.Repositorio;

namespace PrimeiroSite.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio1)
        {
            _contatoRepositorio = contatoRepositorio1;
        }
        public IActionResult Index()
        {
           var contatos =  _contatoRepositorio.BuscarTodos().ToList();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar (ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}
