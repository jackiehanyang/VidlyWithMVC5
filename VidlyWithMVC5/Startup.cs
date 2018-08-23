using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyWithMVC5.Startup))]
namespace VidlyWithMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
