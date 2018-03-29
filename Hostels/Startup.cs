using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Hostels.Startup))]

namespace Hostels
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            new MobileAppConfiguration()
                .UseDefaultConfiguration()
                .MapApiControllers()
                .ApplyTo(config);
                
            app.UseWebApi(config);
        }
    }
}