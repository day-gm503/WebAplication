using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSignosVitales.Startup))]
namespace WebSignosVitales
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
