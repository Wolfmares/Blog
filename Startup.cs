using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WolfmaresBlog.Startup))]
namespace WolfmaresBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
