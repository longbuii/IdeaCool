using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdeaCool.Startup))]
namespace IdeaCool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
