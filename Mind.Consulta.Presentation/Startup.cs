using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mind.Consulta.Presentation.Startup))]
namespace Mind.Consulta.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
