using System.Web;
using System.Web.Mvc;

namespace Mia_OWP_FINALNI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
