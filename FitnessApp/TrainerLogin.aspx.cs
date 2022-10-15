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
    public partial class TrainerLogin : System.Web.UI.Page
    {
        TrainerBL BLL = new TrainerBL();
        Trainer trainer = new Trainer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btntrainerlogin_Click(object sender, EventArgs e)
        {
      
            string username = Request.Form["txtusername"];
            string password = Request.Form["txtpassword"];

            trainer.Username = username;
            trainer.Password = password;

            Session["UserName"] = username;
            Session["Password"] = password;

            int count = BLL.TrainerLoginrBL(trainer);

            if(count > 0)
            {
                Response.Redirect("TrainerDashboard.aspx");
            }
            else
            {
                Response.Redirect("TrainerLogin.aspx");
            }


        }
    }
}