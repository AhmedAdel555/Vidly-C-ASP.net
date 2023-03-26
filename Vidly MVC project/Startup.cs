using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_MVC_project.Startup))]
namespace Vidly_MVC_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
