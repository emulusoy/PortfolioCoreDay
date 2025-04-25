using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class MessageController : Controller
    {
        private readonly PortfolioContext _context;

        public MessageController(PortfolioContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            if (ModelState.IsValid)
            {
                message.SendDate = DateTime.Now;
                message.IsRead = false;

                _context.Messages.Add(message);
                _context.SaveChanges();
                return Content("Mesajınız başarıyla gönderildi.");
            }

            // Hata durumunda sadece formu yeniden göster.
            return Content("Mesaj gönderilirken bir hata oluştu.");
        }
    }
}
