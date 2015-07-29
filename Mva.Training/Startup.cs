using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mva.Training.Startup))]
namespace Mva.Training
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
