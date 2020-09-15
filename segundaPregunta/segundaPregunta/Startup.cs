using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(segundaPregunta.Startup))]
namespace segundaPregunta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
