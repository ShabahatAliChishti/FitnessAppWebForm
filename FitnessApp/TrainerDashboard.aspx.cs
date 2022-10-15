using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["action"] != null)
            {
                // response.clear();
                Session.Abandon();
            }
            if (!this.IsPostBack)
            {
                string user = Session["UserName"].ToString();
                nametxt.InnerText = user;
                nametxts.InnerText = user;
            }
         
        }
    }
}