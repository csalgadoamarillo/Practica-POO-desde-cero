using System.Web;
using System.Web.Mvc;

namespace Practica_POO_desde_cero
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
