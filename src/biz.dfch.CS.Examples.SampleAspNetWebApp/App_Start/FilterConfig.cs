using System.Web;
using System.Web.Mvc;

namespace biz.dfch.CS.Examples.SampleAspNetWebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
