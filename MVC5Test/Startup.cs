using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Test.Startup))]
namespace MVC5Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
