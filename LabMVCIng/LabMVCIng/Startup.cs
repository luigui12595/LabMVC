using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabMVCIng.Startup))]
namespace LabMVCIng
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
