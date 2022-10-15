using FitnessApp.BLL;
using FitnessApp.BOL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp
{
    public partial class CustomerLogin : System.Web.UI.Page
    {
        CustomerBL BLL = new CustomerBL();
        Customer cust = new Customer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btncustomerlogin_Click(object sender, EventArgs e)
        {
            string username = Request.Form["txtusername"];
            string password = Request.Form["txtpassword"];

            cust.Username = username;
            cust.Password = password;

            Session["UserName"] = username;
            Session["Password"] = password;

            int count = BLL.CustomerLoginBL(cust);

            if(count > 0)
            {
                Response.Redirect("CustomerDashboard.aspx");
            }
            else
            {
                Response.Redirect("CustomerLogin.aspx");

            }

        }
    }
}