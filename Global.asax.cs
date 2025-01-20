using Microsoft.Owin;
using Microsoft.Owin.Builder;
using Owin;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

[assembly: OwinStartup(typeof(POCRealTimeBidClock2.MvcApplication))]

namespace POCRealTimeBidClock2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);            

        }
        public void Configuration(IAppBuilder app)
        {
            // SignalR configuration
            app.MapSignalR();
        }
    }
}
