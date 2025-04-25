using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult PortfolioList()
        {
            var values=context.Portfolios.Include(x=>x.Category).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            var values =new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName");
            ViewBag.Bag = values;
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio value)
        {
            context.Portfolios.Add(value);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
        public IActionResult DeletePortfolio(int id)
        {
            var val = context.Portfolios.Find(id);
            context.Portfolios.Remove(val);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName");
            ViewBag.Bag = values;
            var val = context.Portfolios.Find(id);
            return View(val);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio value)
        {
           
            context.Portfolios.Update(value);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
