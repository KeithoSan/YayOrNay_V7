using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YayOrNay_V7.Startup))]
namespace YayOrNay_V7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
