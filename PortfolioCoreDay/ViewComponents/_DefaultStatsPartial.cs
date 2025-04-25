using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultStatsPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.SkillsCount = context.Skills.Count();
            ViewBag.PortfoliosCount = context.Portfolios.Count();
            ViewBag.MessagesCount = context.Messages.Count();
            Random random = new Random();
            ViewBag.RandomValue=random.Next(10, 30);

            return View();
        }
    }
}
