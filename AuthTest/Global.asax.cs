using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Globalization;
using System.Threading;

namespace AuthTest
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

        private void SetCulture()
        {
            CultureInfo threadCultureInfo = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            CultureInfo uiCultureInfo = (CultureInfo)CultureInfo.CurrentUICulture.Clone();
            threadCultureInfo.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";

            uiCultureInfo.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";

            Thread.CurrentThread.CurrentCulture = threadCultureInfo;
            Thread.CurrentThread.CurrentUICulture = uiCultureInfo;
        }

        public void Application_BeginRequest(object sender, EventArgs e)
        {
            SetCulture();
        }
    }
}
