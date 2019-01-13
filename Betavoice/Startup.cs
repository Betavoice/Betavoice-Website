using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Betavoice.Startup))]
namespace Betavoice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
