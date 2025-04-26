using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _Sidebar : ViewComponent
    { 
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {       
            return View(context.SocialMedias.ToList());
        }
    }
}
