using System.Web.Mvc;

namespace Project.MVCUI.Areas.ExtraEmployee
{
    public class ExtraEmployeeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ExtraEmployee";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ExtraEmployee_default",
                "ExtraEmployee/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}