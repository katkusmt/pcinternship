using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pc_internship.Startup))]
namespace pc_internship
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
