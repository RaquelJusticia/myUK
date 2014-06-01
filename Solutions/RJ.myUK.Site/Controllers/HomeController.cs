using System.Web.Mvc;
using RJ.myUK.Site.ServiceLibrary;

namespace RJ.myUK.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICurrencyManager _currencyManager;

        public HomeController(ICurrencyManager currencyManager)
        {
            _currencyManager = currencyManager;
        }

        public ActionResult Index()
        {
            var rate = _currencyManager.GetExchangeRate();
            return View(rate);
        }
    }
}
