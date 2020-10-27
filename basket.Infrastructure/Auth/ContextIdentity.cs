using System.Security.Principal;

namespace basket.Infrastructure.Auth
{
    public class ContextIdentity : GenericIdentity
    {
        public ContextIdentity() : base(string.Empty)
        { }

        public string UserName { get; set; }

        //public string Role { get; set; }
    }
}
