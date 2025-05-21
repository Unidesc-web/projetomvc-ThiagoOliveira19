using Microsoft.AspNetCore.Mvc;
using VulnerabilidadesApp.Models;
using VulnerabilidadesApp.Data;

namespace VulnerabilidadesApp.Controllers
{
    public class VulnerabilidadesController : Controller
    {
        private readonly VulnerabilidadeRepository _repository;

        public VulnerabilidadesController()
        {
            _repository = new VulnerabilidadeRepository();
        }

        public IActionResult Index()
        {
            var vulnerabilidades = _repository.ObterTodas();
            return View(vulnerabilidades);
        }

        public IActionResult Details(int id)
        {
            var vulnerabilidade = _repository.ObterPorId(id);
            if (vulnerabilidade == null)
            {
                return NotFound();
            }
            return View(vulnerabilidade);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vulnerabilidade vulnerabilidade)
        {
            if (ModelState.IsValid)
            {
                _repository.Adicionar(vulnerabilidade);
                return RedirectToAction(nameof(Index));
            }
            return View(vulnerabilidade);
        }

        public IActionResult Edit(int id)
        {
            var vulnerabilidade = _repository.ObterPorId(id);
            if (vulnerabilidade == null)
            {
                return NotFound();
            }
            return View(vulnerabilidade);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Vulnerabilidade vulnerabilidade)
        {
            if (id != vulnerabilidade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _repository.Atualizar(vulnerabilidade);
                return RedirectToAction(nameof(Index));
            }
            return View(vulnerabilidade);
        }

        public IActionResult Delete(int id)
        {
            var vulnerabilidade = _repository.ObterPorId(id);
            if (vulnerabilidade == null)
            {
                return NotFound();
            }
            return View(vulnerabilidade);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repository.Remover(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
