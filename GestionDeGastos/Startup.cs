using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestionDeGastos.Startup))]
namespace GestionDeGastos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
