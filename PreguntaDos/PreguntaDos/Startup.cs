using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreguntaDos.Startup))]
namespace PreguntaDos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
