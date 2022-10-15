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
    public partial class TrainerSignUp : System.Web.UI.Page
    {
        TrainerBL BLL = new TrainerBL();
        Trainer trainer = new Trainer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnacccreate_Click(object sender, EventArgs e)
        {
            string firstname = Request.Form["txtfirstname"];
            string lastname = Request.Form["txtlastname"];
            string mobileno = Request.Form["txtmobileno"];
            string address = Request.Form["txtaddress"];
            string expertise = Request.Form["txtexpertise"];
            string username = Request.Form["txtusername"];
            string password = Request.Form["txtpassword"];

            trainer.FirstName = firstname;
            trainer.LastName = lastname;
            trainer.MobileNo = mobileno;
            trainer.Address = address;
            trainer.Expertise = expertise;
            trainer.Username = username;
            trainer.Password = password;

            int count = BLL.TrainerSignUpBL(trainer);

            if(count > 0)
            {
                Response.Redirect("TrainerLogin.aspx");

            }
            else
            {
                Response.Redirect("TrainerSignUp.aspx");

            }
        }
    }
}