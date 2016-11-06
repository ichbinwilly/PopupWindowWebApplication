using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PopupWindowWebApplication.Startup))]
namespace PopupWindowWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
