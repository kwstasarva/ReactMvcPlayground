using System.Web;
using System.Web.Mvc;

namespace ReactMvcPlayground
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
