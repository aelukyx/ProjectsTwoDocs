using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sistratur.WebApp.Startup))]
namespace Sistratur.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
