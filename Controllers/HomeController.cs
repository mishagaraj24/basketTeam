using basKet.Attributes;
using System.Web.Mvc;

namespace basKet.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        [CustomAuthorize("Admin")]
        public ActionResult Index()
        {
            User u = new User();
            u.Username = "Customer";
            return View(u);
        }
    }
}