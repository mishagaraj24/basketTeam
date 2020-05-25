using basket.DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace basKet.Attributes
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly List<string> AllowedRoles;
        private UsersRepository repository = new UsersRepository();

        public CustomAuthorizeAttribute(params string[] roles)
        {
            AllowedRoles = roles.ToList();
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if(!AllowedRoles.Any())
            {
                return true;
            }

            if (AllowedRoles.Contains("Admin"))
            {
                var userId = httpContext.Request.Cookies.Get("userId");
                var dbUser = repository.GetUser(userId.Value);

                if (!dbUser.IsAdmin)
                {
                    return false;
                }

            }

            return true;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new HttpUnauthorizedResult("User is not authorized to access this page.");
        }
    }
}