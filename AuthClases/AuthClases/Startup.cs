using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthClases.Startup))]
namespace AuthClases
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
