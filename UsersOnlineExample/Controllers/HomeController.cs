using System.Web.Mvc;

namespace UsersOnlineExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SecondPage()
        {
            return View();
        }
    }
}
