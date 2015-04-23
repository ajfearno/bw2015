using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrookfieldMidwivesApp.Startup))]
namespace BrookfieldMidwivesApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
