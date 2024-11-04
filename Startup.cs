using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mia_OWP_FINALNI.Startup))]
namespace Mia_OWP_FINALNI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
