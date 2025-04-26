using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class AdminEducationController : Controller
    {

        PortfolioContext context = new PortfolioContext();
        public IActionResult EducationList()
        {
            var values = context.Educations.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEducation(Education Education)
        {
            context.Educations.Add(Education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        public IActionResult DeleteEducation(int id)
        {
            var values = context.Educations.Find(id);
            context.Educations.Remove(values);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var values = context.Educations.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateEducation(Education Education)
        {
            context.Educations.Update(Education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}
