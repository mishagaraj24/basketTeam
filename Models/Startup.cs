
    using Microsoft.Owin;
    using Owin;
[assembly: OwinStartup(typeof(basKet.Models.Chat))]
namespace basKet.Models
    {
        public class Chat
        {
            public void Configuration(IAppBuilder app)
            {
                app.MapSignalR();
            }
        }
    }
