using Microsoft.AspNetCore.Mvc;
using Race.DATA.Models;
using Race.DATA.Services;

namespace Race.WEB.Controllers
{
    public class PilotsController : Controller
    {
        private PilotsService sPilotsService = new PilotsService();
        public IActionResult Index() => View(sPilotsService.sRepositoryPilots.GetAll());
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(Pilots entity)
        {
            if (!ModelState.IsValid) return View();
            sPilotsService.sRepositoryPilots.AddEntity(entity);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id) => View(sPilotsService.sRepositoryPilots.Get(id));
        [HttpPost]
        public IActionResult Edit(Pilots entity)
        {
            sPilotsService.sRepositoryPilots.Update(entity);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            sPilotsService.sRepositoryPilots.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
