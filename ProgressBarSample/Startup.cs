using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProgressBarSample.Startup))]
namespace ProgressBarSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
