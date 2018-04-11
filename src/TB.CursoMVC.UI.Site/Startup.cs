using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TB.CursoMVC.UI.Site.Startup))]
namespace TB.CursoMVC.UI.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
