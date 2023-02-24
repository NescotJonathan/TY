using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace AramarkFinal
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //Declares the session variables and sets all their values to 0
            Session["QuantityCheese"] = 0;
            Session["QuantityPepperoni"] = 0;
            Session["OrderTotal"] = 0.0;
        }
    }
}