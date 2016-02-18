using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcMove.Startup))]
namespace MvcMove
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
