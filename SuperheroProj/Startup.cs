using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperheroProj.Startup))]
namespace SuperheroProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
