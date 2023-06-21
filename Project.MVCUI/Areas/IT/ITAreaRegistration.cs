using System.Web.Mvc;

namespace Project.MVCUI.Areas.IT
{
    public class ITAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "IT";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "IT_default",
                "IT/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}