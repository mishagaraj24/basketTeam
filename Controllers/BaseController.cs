using basket.Infrastructure.Auth;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace basKet.Controllers
{
    public class BaseController : System.Web.Mvc.Controller
    {
        public ContextIdentity AuthorizationContext { get; set; }

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            var keys = filterContext.HttpContext.Request.Cookies.AllKeys.ToList();

            if (!keys.Contains("isUserAuthorized"))
            {
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                     { "controller", "Login" },
                     { "action", "Index" }
                });
            }
        }
    }
}