using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class AdminFeatureController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult FeatureList()
        {
            var values = context.Jobs.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFeature(Job Feature)
        {
            context.Jobs.Add(Feature);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        public IActionResult DeleteFeature(int id)
        {
            var values = context.Jobs.Find(id);
            context.Jobs.Remove(values);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = context.Jobs.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Job Feature)
        {
            context.Jobs.Update(Feature);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}
