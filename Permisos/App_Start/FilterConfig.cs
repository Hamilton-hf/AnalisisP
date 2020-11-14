using System.Web;
using System.Web.Mvc;

namespace Permisos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Filters.VerificarSesion());
            
        }
    }
}
