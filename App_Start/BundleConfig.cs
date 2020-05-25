using System.Web;
using System.Web.Optimization;

namespace basKet
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
          

            bundles.Add(new ScriptBundle("~/Scripts/").Include(
                      "~/Scripts/jquery-1.12.1.min.js",
                      "~/Scripts/popper.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/aos.js",
                      "~/Scripts/jquery.magnific-popup.js",
                      "~/Scripts/masonry.pkgd.js",
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/swiper.min.js",
                      "~/Scripts/swiper_custom.js",
                      "~/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/animate.css",
                      "~/Content/owl.carousel.min.css",
                      "~/Content/themify-icons.css",
                      "~/Content/flaticon.css",
                      "~/Content/magnific-popup.css",
                      "~/Content/swiper.min.css",
                      "~/Content/Login.css", 
                      "~/Content/Registration.css",
                      "~/Content/style.css"
                      ));
        }
    }
}
