using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Hostels.Startup))]

namespace Hostels
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}