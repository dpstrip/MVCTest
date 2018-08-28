using MVCWebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Filters
{
    public class HeaderFooterFilter:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ViewResult v = filterContext.Result as ViewResult;
            if(v!=null)//v will null when v is not in viewresult
            {
                BaseViewModel bvm = v.Model as BaseViewModel;
                if(bvm != null)
                {
                    bvm.UserName = HttpContext.Current.User.Identity.Name;
                    bvm.FooterData = new FooterViewModel();
                    bvm.FooterData.CompanyName = "David's Company";
                    bvm.FooterData.Year = DateTime.Now.Year.ToString();
                }
            }


        }
    }
}