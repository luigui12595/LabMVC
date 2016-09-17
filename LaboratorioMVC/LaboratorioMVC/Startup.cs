using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaboratorioMVC.Startup))]
namespace LaboratorioMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
