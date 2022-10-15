using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp
{
    public partial class CustomerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user =  Session["UserName"].ToString();
            nametxt.InnerText = user;
            nametexts.InnerText = user;
            if (Request.QueryString["action"] != null)
            {
                // response.clear();
                Session.Abandon();
            }
        }
      
        protected void Delete(object sender, EventArgs e)
        {
            Response.Redirect("CustomerLogin.aspx");

        }

    }
}