using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB_23.Startup))]
namespace LAB_23
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
