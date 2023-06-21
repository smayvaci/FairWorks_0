using System.Web.Mvc;

namespace Project.MVCUI.Areas.SalesEmployee
{
    public class SalesEmployeeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SalesEmployee";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SalesEmployee_default",
                "SalesEmployee/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}