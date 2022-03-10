using System.Web.Mvc;

namespace ASPMVC_Tsk01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Main Page";

            return View();
        }
    }
}