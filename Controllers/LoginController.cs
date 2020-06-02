using basket.DataAccess;
using basket.Infrastructure;
using basket.Infrastructure.Auth;
using basKet.Models;
using System;
using System.Web;
using System.Web.Mvc;
using basket.ApplicationServices;
using System.Linq;
using System.Security.Principal;

namespace basKet.Controllers
{
    public class LoginController : System.Web.Mvc.Controller
    {
        private LoginService loginSerivce = new LoginService();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login loginDetails)
        {
            var errors = loginSerivce.ValidateCredentials(loginDetails.Username, loginDetails.Password);

            if (errors.Any())
            {
                ModelState.AddModelError(string.Empty, errors.First().Message);
                return View("Index");
            }

            SetAuthCookie(HttpContext.ApplicationInstance.Context, loginDetails.Username);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            var httpContext = HttpContext.ApplicationInstance.Context;

            httpContext.Response.Cookies.Remove("isUserAuthorized");

            return RedirectToAction("Index","Login");
        }

        private void SetAuthCookie(HttpContext httpContext, string userName)
        {
            //TODO add identity

            ContextIdentity identity = new ContextIdentity();
            identity.UserName = userName;

            var roles = new string[] { "User" };

            GenericPrincipal genericPrincipal = new GenericPrincipal(identity, roles);

            httpContext.User = genericPrincipal;

            HttpCookie cookie = new HttpCookie("isUserAuthorized");
            cookie.Value = "true";
            cookie.Expires = DateTime.Now.AddMinutes(10);

            httpContext.Response.SetCookie(cookie);

            httpContext.Response.SetCookie(new HttpCookie("userId") {Value = userName});
        }
    }
}