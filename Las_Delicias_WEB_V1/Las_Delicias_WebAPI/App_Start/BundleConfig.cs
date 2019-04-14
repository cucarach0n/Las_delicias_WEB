using System.Web;
using System.Web.Optimization;

namespace Las_Delicias_WebAPI
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.2.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/holder").Include(
                      "~/Scripts/holder.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css"
                      ,"~/Content/site.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/font-awesome").Include("~/Content/font-awesome.min.css"
                      ));
            bundles.Add(new StyleBundle("~/Content/animate").Include("~/Content/animate.css"
                      ));
            bundles.Add(new StyleBundle("~/Content/style").Include("~/Content/style.css"
                      ));
            bundles.Add(new StyleBundle("~/Content/nuevo").Include("~/Content/nuevo.css"
                      ));
            bundles.Add(new StyleBundle("~/Content/owlcarousel").Include("~/Content/owl.carousel.css"
                      ));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap4.1.min.css"
                      ));
            bundles.Add(new StyleBundle("~/Content/carousel").Include(
                      "~/Content/carousel.css"));
            bundles.Add(new StyleBundle("~/Content/menuEstilo").Include(
                      "~/Content/menuEstilo.css"));
            bundles.Add(new ScriptBundle("~/bundles/ScriptMenu").Include(
                      "~/Scripts/ScriptMenu.js"));
            bundles.Add(new ScriptBundle("~/bundles/owlcarousel").Include("~/Scripts/owl.carousel.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/main").Include("~/Scripts/main.js"));
        }
    }
}
