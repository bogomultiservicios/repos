using System.Web;
using System.Web.Mvc;

namespace MVCAPI2019CRUD23
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
