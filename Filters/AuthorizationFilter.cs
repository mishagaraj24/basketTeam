using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace basKet.Filters
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            //var keys = filterContext.HttpContext.Request.Cookies.AllKeys.ToList();

            //if (!keys.Contains("isUserAuthorized"))
            //{
            //    filterContext.Result = new RedirectToRouteResult(
            //    new RouteValueDictionary
            //    {
            //         { "controller", "Login" },
            //         { "action", "Index" }
            //    });
            //}
        }
    }
}