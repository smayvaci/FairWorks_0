using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.AuthenticanClasses
{
    public class SuperAdminAuthentication:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["superAdmin"] != null) return true;
            httpContext.Response.Redirect("/Home/Login");
            return false;
        }
    }
}