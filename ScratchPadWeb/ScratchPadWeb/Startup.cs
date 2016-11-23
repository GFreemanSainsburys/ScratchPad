using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScratchPadWeb.Startup))]
namespace ScratchPadWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Adding comment
            ConfigureAuth(app);
        }
    }
}
