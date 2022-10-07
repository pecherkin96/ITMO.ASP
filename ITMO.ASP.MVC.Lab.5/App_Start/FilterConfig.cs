using System.Web;
using System.Web.Mvc;

namespace ITMO.ASP.MVC.Lab._5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
