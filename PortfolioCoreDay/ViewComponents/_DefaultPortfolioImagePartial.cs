using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context; // Include kullanabilmek için

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultPortfolioImagePartial : ViewComponent
    {
        PortfolioContext context=new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            // Category ile birlikte Portfolyoları getiriyoruz
            var values = context.Portfolios.Include(x => x.Category).ToList();

            return View(values);
        }
    }
}

