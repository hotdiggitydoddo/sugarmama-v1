using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SugarMama.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/jquery.validate.unobtrusive.js"
                ));

            bundles.Add(new StyleBundle("~/content/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/custom.css"
                ));
        }
    }
}