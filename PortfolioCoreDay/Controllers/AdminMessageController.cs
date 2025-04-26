using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class AdminMessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult MessageList()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        
    }
}
