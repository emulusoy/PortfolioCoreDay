using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class AdminContactController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ContactList()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateContact(Contact Contact)
        {
            context.Contacts.Add(Contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
        public IActionResult DeleteContact(int id)
        {
            var values = context.Contacts.Find(id);
            context.Contacts.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var values = context.Contacts.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateContact(Contact Contact)
        {
            context.Contacts.Update(Contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
