using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FloorPlan.Startup))]
namespace FloorPlan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
