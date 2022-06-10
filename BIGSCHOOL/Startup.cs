using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BIGSCHOOL.Startup))]
namespace BIGSCHOOL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
