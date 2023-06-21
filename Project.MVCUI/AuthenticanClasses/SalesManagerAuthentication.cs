using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.AuthenticanClasses
{
    public class SalesManagerAuthentication:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["salesManager"] != null) return true;
            httpContext.Response.Redirect("/Home/Login");
            return false;
        }
    }
}