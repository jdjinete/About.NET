using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UIPresentation.Startup))]
namespace UIPresentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
