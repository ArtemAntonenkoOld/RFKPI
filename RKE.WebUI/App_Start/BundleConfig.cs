using System.Web;
using System.Web.Optimization;

namespace RKE.WebUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jquerysemantic").Include(
                        "~/Scripts/jquery-{version}.js",
                         "~/Scripts/bootstrap.min.js",
                         "~/Scripts/semantic-auto-complete/Semantic-UI-CSS-master/semantic.min.js",
                         "~/Scripts/bootstrap-datetimepicker.js",
                         "~/Scripts/bootstrap-datetimepicker.ua.js"


                ));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/semantic").Include(
                        "~/Scripts/semantic-auto-complete/Semantic-UI-CSS-master/semantic.min.js")
                );
            bundles.Add(new StyleBundle("~/Scripts/semantic-auto-complete/Semantic-UI-CSS-master").Include(
                      "~/Scripts/semantic-auto-complete/Semantic-UI-CSS-master/semantic.min.css",
                      "~/Content/bootstrap-datetimepicker.css"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/jquery-1.10.2.js", 
                      "~/Scripts/angular.js"));
           
            bundles.Add(new StyleBundle("~/Content/LessonsForStudents").Include(
                       "~/Content/LessonsForStudents.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/index").Include(
                     "~/Content/index.css"));
        }
    }
}
