using Microsoft.AspNetCore.Mvc;
using MiniProjetDotNet.Interfaces;
using MiniProjetDotNet.Models;
using MiniProjetDotNet.Services;
namespace MiniProjetDotNet.Controllers
{
    public class SalarieController : Controller
    {
        private readonly ISalarieService _salarie;
        public SalarieController(ISalarieService salarieService)
        {
            this._salarie = salarieService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var salarieService = await this._salarie.GetAll();
            return View(salarieService);
        }

        public async Task<IActionResult>Details(int id)
        {
           var sal = await this._salarie.GetById(id);
            return View(sal); 
        }
        [HttpGet]
        public IActionResult Ajouter()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Ajouter(Salarie salarie)
        {
            await this._salarie.Add(salarie);
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Supprimer(int id)
        {
            var a = await this._salarie.GetById(id);
            return View(a);
        }

        [HttpPost]
        public async Task<IActionResult> SupprimerPost(int id)
        {
            if (!await this._salarie.Exists(id))

                return NotFound();
            await this._salarie.Delete(id);
            return RedirectToAction(nameof(All));

        }

        [HttpGet]
        public async Task<IActionResult>Modifier(int id)
        {
           var sal = await this._salarie.GetById(id);
            return View(sal);
        }
        
        [HttpPost]
          public async Task<IActionResult>Modifier(Salarie salarie)
        {
            await this._salarie.Update(salarie);
            return RedirectToAction(nameof(All));
        }
    }
}