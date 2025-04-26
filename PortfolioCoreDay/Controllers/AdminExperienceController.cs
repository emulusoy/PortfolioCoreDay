using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class AdminExperienceController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience Experience)
        {
            context.Experiences.Add(Experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = context.Experiences.Find(id);
            context.Experiences.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values = context.Experiences.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience Experience)
        {
            context.Experiences.Update(Experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
