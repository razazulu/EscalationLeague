using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EscalationLeague.Startup))]
namespace EscalationLeague
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
