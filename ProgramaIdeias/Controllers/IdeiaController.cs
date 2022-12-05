using Microsoft.AspNetCore.Mvc;
using ProgramaIdeias.Models;
using System.Diagnostics;

namespace ProgramaIdeias.Controllers
{
    public class IdeiaController : Controller
    {
        private readonly Contexto _context;

        public IdeiaController(Contexto contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Ideia ideia = new(_context);
            return View(ideia);
        }
        public IActionResult Leaderboard()
        {
            return View();
        }
        public IActionResult Create()
		{
			Ideia ideia = new(_context);
			return View(ideia);
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Ideia ideia) {
            try
            {
                ideia.Data = DateTime.Now;
                ideia.Status = "Em Análise";
                _context.Add(ideia);
                _context.SaveChanges();
                foreach (var participante in ideia.Participantes)
                {
                    EquipeIdeia equipeIdeia = new(participante, ideia.IDIdeia);
                    _context.Add(equipeIdeia);
                    _context.SaveChanges();//Verificar como funciona o SaveChanges e considerar possível melhoria de desempenho
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                TempData["Mensagem Erro"] = "Houve um erro, por favor tente novamente, detalhe do erro:" + ex.Message;
                return View("Create",ideia);
            }
        }
	}
}