using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class AdminServiceController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ServiceList()
        {
            var values = context.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateService(Service Service)
        {
            context.Services.Add(Service);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        public IActionResult DeleteService(int id)
        {
            var values = context.Services.Find(id);
            context.Services.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = context.Services.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateService(Service Service)
        {
            context.Services.Update(Service);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
    }
}
