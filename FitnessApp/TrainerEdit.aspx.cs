using FitnessApp.BLL;
using FitnessApp.BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp
{
    public partial class TrainerEdit : System.Web.UI.Page
    {
        TrainerBL BLL = new TrainerBL();
        Trainer trainer = new Trainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["action"] != null)
            {
                // response.clear();
                Session.Abandon();
            }
            if (!this.IsPostBack)
            {
                DataTable dt = Session["TrainerData"] as DataTable;
                string FirstName = dt.Rows[0].Field<string>("FirstName");
                string LastName = dt.Rows[0].Field<string>("LastName");
                string MobileNo = dt.Rows[0].Field<string>("MobileNo");
                string Address = dt.Rows[0].Field<string>("Address");
                string Expertise = dt.Rows[0].Field<string>("Expertise");

                txtfirstname.Text = FirstName;
                txtlastname.Text = LastName;
                txtmobileno.Text = MobileNo;
                txtaddress.Text = Address;
                txtexpertise.Text = Expertise;

                string user = Session["UserName"].ToString();
                Session["User"] = user;
                nametxt.InnerText = user;
                nametxts.InnerText = user;
            }

        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string user = Session["User"].ToString();
            string firstname = txtfirstname.Text;
            string lastname = txtlastname.Text;
            string mobileno = txtmobileno.Text;
            string address = txtaddress.Text;
            string expertise = txtexpertise.Text;

            trainer.FirstName = firstname;
            trainer.LastName = lastname;
            trainer.MobileNo = mobileno;
            trainer.Address = address;
            trainer.Expertise = expertise;
            trainer.Username = user;
            int count = BLL.EditTrainerBL(trainer);
          
            if(count > 0)
            {
                Response.Redirect("TrainerDashboard.aspx");

            }
            else
            {
                Response.Redirect("TrainerEdit.aspx");

            }
        }
    }
}