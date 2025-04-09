using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class SkillController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult SkillList()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(Skill Skill)
        {
            context.Skills.Add(Skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = context.Skills.Find(id);
            context.Skills.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = context.Skills.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill Skill)
        {
            context.Skills.Update(Skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}
