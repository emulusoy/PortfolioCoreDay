using System;
using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext context=new PortfolioContext();



        [HttpPost]
        public async Task<IActionResult> SendMessage(Message message)
        {
            if (ModelState.IsValid)
            {
                message.SendDate = DateTime.Now;   
                message.IsRead = false;

                context.Messages.Add(message);
                await context.SaveChangesAsync();

                TempData["Success"] = "Mesaj başarıyla gönderildi.";
                return RedirectToAction("Index", "Default");
            }

            TempData["Error"] = "Bir hata oluştu.";
            return RedirectToAction("Index", "Default");
        }
    }
}
