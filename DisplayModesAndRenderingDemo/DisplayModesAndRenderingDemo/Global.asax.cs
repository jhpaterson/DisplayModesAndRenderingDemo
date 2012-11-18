using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;

namespace DisplayModesAndRenderingDemo
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            // Demo:
            // access /Home/Index from desktop browser, see Index.cshtml view
            // access /Home/Index from iPhone, see Index.iphone.cshtml view
            // access /Home/Index from Android, see Index.android.cshtml view 
            // comment out iphone display mode
            // access /Home/Index from iPhone, see Index.mobile.cshtml view 
            // can use simulator or Firefox with User Agent Switcher extension
            DisplayModeConfig.RegisterDisplayModes(DisplayModeProvider.Instance.Modes);
        }
    }
}