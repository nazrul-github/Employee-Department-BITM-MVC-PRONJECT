using System.Web;
using System.Web.Mvc;

namespace EmployeeDepartmentMvcProject29._09._19
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
