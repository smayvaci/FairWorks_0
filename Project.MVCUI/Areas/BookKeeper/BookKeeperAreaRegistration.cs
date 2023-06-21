using System.Web.Mvc;

namespace Project.MVCUI.Areas.BookKeeper
{
    public class BookKeeperAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BookKeeper";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BookKeeper_default",
                "BookKeeper/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}