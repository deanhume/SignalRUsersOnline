namespace UsersOnlineExample
{
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using UsersOnlineExample.Utils;

    public class MvcApplication : System.Web.HttpApplication
    {
        readonly UserActivityHub userActivityHub = new UserActivityHub();

        /// <summary>
        /// This method is fired when the application starts up.
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RouteTable.Routes.MapHubs();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}