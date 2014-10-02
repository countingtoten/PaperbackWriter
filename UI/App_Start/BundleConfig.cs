using System.Web;
using System.Web.Optimization;

namespace UI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/requirejs").Include(
                        "~/Scripts/require.js",
                        "~/Scripts/common.js"));
        }
    }
}