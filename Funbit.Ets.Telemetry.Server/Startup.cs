using System;
using System.Net.Http.Formatting;
using System.Web.Http;
using ICE.VTC.TELEMETRY.Helpers;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace ICE.VTC.TELEMETRY
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();
            
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters
                  .JsonFormatter
                  .SerializerSettings = JsonHelper.RestSettings;
            
            config.MapHttpAttributeRoutes();
            config.EnsureInitialized();

            GlobalHost.Configuration.ConnectionTimeout = TimeSpan.FromSeconds(12);
            GlobalHost.Configuration.DisconnectTimeout = TimeSpan.FromSeconds(9);
            GlobalHost.Configuration.KeepAlive = TimeSpan.FromSeconds(3);
            appBuilder.MapSignalR();

            appBuilder.UseWebApi(config);
            appBuilder.UseCors(CorsOptions.AllowAll);
        }
    }
}
