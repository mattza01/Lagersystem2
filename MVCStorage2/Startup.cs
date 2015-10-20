using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCStorage2.Startup))]
namespace MVCStorage2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
