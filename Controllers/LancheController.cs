using Microsoft.AspNetCore.Mvc;
using suave.Repositories.Interfaces;
using suave.ViewModels;

namespace suave.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria atual";

            return View(lanchesListViewModel);
        }
    }
}