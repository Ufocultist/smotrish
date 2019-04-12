using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(smotrish.Startup))]
namespace smotrish
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
