using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRDemo.Startup))]

namespace SignalRDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
