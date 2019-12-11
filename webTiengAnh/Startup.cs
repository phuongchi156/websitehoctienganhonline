using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webTiengAnh.Startup))]
namespace webTiengAnh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
