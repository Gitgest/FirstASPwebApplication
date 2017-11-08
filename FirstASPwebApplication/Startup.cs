using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstASPwebApplication.Startup))]
namespace FirstASPwebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
