using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class AdminAboutController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult AboutList()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About About)
        {
            context.Abouts.Add(About);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public IActionResult DeleteAbout(int id)
        {
            var values = context.Abouts.Find(id);
            context.Abouts.Remove(values);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = context.Abouts.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About About)
        {
            context.Abouts.Update(About);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
