using System.Web;
using System.Web.Optimization;

namespace MVC_starter
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {  
            bundles.Add(new StyleBundle("~/Content/css").Include(
                  //BEGIN GLOBAL MANDATORY STYLES
                  "~/Content/assets/global/plugins/font-awesome/css/font-awesome.min.css",
                  "~/Content/assets/global/plugins/simple-line-icons/simple-line-icons.min.css",
                  "~/Content/assets/global/plugins/bootstrap/css/bootstrap.min.css",
                  "~/Content/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css",
                  //BEGIN PAGE LEVEL PLUGINS
                  "~/Content/assets/global/plugins/bootstrap-daterangepicker/daterangepicker.min.css",
                  "~/Content/assets/global/plugins/morris/morris.css",
                  "~/Content/assets/global/plugins/fullcalendar/fullcalendar.min.css",
                  "~/Content/assets/global/plugins/jqvmap/jqvmap/jqvmap.css",
                  //BEGIN THEME GLOBAL STYLES
                   "~/Content/assets/global/css/components-md.min.css",
                  "~/Content/assets/global/css/plugins-md.min.css",
                  //BEGIN THEME LAYOUT STYLES,
                   "~/Content/assets/layouts/css/layout.min.css",
                  "~/Content/assets/layouts/css/themes/darkblue.min.css",
                   "~/Content/assets/layouts/css/custom.min.css"
                  ));


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    //-BEGIN CORE PLUGINS
                    "~/Script/assets/global/plugins/jquery.min.js",
                    "~/Script/assets/global/plugins/bootstrap/js/bootstrap.min.js",
                    "~/Script/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                    "~/Script/assets/global/plugins/jquery.blockui.min.js",
                    "~/Script/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                    //BEGIN PAGE LEVEL PLUGINS
                    //BEGIN THEME GLOBAL SCRIPTS
                    "~/Script/assets/global/scripts/app.min.js",
                    //BEGIN PAGE LEVEL SCRIPTS
                    "~/Script/assets/pages/scripts/dashboard.min.js",
                    //BEGIN THEME LAYOUT SCRIPTS
                    "~/Script/assets/layouts/scripts/layout.min.js",
                    "~/Script/assets/layouts/scripts/demo.min.js",
                    "~/Script/assets/layouts/global/scripts/quick-sidebar.min.js",
                    "~/Script/assets/layouts/global/scripts/quick-nav.min.js"
                    ));




        }
    }
}
