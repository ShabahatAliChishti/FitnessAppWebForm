using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FitnessApp.BOL;
using FitnessApp.BLL ;
namespace FitnessApp
{
    public partial class CustomerSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncusacc_Click(object sender, EventArgs e)
        {
            CustomerBL BLL = new CustomerBL();
            string firstname = Request.Form["txtfirstname"];
            string lastname = Request.Form["txtlastname"];
            string mobileno = Request.Form["txtmobileno"];
            string address = Request.Form["txtaddress"];
            string username = Request.Form["txtusername"];
            string password = Request.Form["txtpassword"];
            Customer cust = new Customer();
            cust.FirstName = firstname;
            cust.LastName = lastname;
            cust.MobileNo = mobileno;
            cust.Address = address;
            cust.Username = username;
            cust.Password = password;
            BLL.CustomerSignupBL(cust);
            Response.Redirect("CustomerLogin.aspx");
        }
    }
}
