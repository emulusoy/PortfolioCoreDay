using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultServicePartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            // Category ile birlikte Portfolyoları getiriyoruz
            var values = context.Services.Take(6).ToList();

            return View(values);
        }
    }
}
