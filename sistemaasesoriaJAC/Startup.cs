using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sistemaasesoriaJAC.Startup))]
namespace sistemaasesoriaJAC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
