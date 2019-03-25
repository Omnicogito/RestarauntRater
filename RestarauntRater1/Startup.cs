using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestarauntRater1.Startup))]
namespace RestarauntRater1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
