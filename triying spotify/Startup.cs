using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(triying_spotify.Startup))]
namespace triying_spotify
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
