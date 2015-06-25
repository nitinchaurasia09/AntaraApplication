using Microsoft.Owin;
using Owin;

//[assembly: OwinStartupAttribute(typeof(AntaraApplication.Startup))]
namespace AntaraApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
