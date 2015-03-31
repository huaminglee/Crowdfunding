using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crowdfunding.Startup))]
namespace Crowdfunding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
