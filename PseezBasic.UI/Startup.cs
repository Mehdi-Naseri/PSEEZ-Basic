using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PseezBasic.UI.Startup))]
namespace PseezBasic.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
