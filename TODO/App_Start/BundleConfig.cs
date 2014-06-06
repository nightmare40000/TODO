using System.Web.Optimization;

namespace TODO.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Style/General").Include(
                "~/Scripts/Styles.css"
                 ));
        }
    }
}