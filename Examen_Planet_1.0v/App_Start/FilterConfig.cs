using System.Web;
using System.Web.Mvc;

namespace Examen_Planet_1._0v
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
