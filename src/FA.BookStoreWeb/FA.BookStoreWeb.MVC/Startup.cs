using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(FA.BookStoreWeb.MVC.Startup))]
namespace FA.BookStoreWeb.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
