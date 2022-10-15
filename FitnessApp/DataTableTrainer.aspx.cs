using FitnessApp.BLL;
using FitnessApp.BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessApp
{
    public partial class DataTableTrainer : System.Web.UI.Page
    {
        string username = "";
        string password = "";
        TrainerBL BLL = new TrainerBL();
        Trainer trainer = new Trainer();
        protected void Page_Load(object sender, EventArgs e)
        {
         
            if (!this.IsPostBack)
            {
                username = Session["UserName"].ToString();
                password = Session["Password"].ToString();
                nametxt.InnerText = username;
                nametxts.InnerText = username;
                Session["User"] = username;

                trainer.Username = username;

                DataTable dummy1 = BLL.GetAllTrainerBL(trainer);
 
                Session["TrainerData"] = dummy1;
                GridView1.DataSource = dummy1;
                GridView1.DataBind();
            
            }
            if (Request.QueryString["action"] != null)
            {
                // response.clear();
                Session.Abandon();
            }
        }
 
    

        protected void btnedit_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrainerEdit.aspx");
        }
        protected void btndelete_Click(object sender, EventArgs e)
        {
            string user = Session["User"].ToString();
            trainer.Username = user;
            int count = BLL.DeleteTrainerBL(trainer);

            if(count > 0)
            {
                Response.Redirect("TrainerLogin.aspx");
            }
            else
            {
                Response.Redirect("DataTableTrainer.aspx");

            }

        }

    }
}