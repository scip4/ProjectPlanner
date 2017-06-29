using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectPlan.Startup))]
namespace ProjectPlan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
