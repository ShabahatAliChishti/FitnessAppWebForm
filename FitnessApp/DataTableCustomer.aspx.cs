using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FitnessApp.BLL;
using FitnessApp.BOL;

namespace FitnessApp
{
    public partial class DataTableCustomer : System.Web.UI.Page
    {
        string username = "";
        string password = "";
        CustomerBL BLL = new CustomerBL();
        Customer cust = new Customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["action"] != null)
            {
                // response.clear();
                Session.Abandon();
            }
            if (!this.IsPostBack)
            {
                username = Session["UserName"].ToString();
                password = Session["Password"].ToString();

                Session["User"] = username;
                nametxt.InnerText = username;
                nametexts.InnerText = username;
                DataTable dummy1 = BLL.GetAllCustomersBL(cust);

                //Session["TrainerData"] = dummy1;
                GridView1.DataSource = dummy1;
                GridView1.DataBind();

            }
        }

        //public static DataTable GetCustomers(string username, string password)
        //{
        //    DataTable dummy = new DataTable();
        //    dummy.Columns.Add("FirstName");
        //    dummy.Columns.Add("LastName");
        //    dummy.Columns.Add("MobileNo");
        //    dummy.Columns.Add("Address");
        //    dummy.Columns.Add("Expertise");

        //    List<string> customers = new List<string>();
        //    string constr = "data source=JUNAIDTASAWAR; database=FitnessDb; integrated security=true;";
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_trainer", con))
        //        {
        //            con.Open();
        //            using (SqlDataReader sdr = cmd.ExecuteReader())
        //            {
        //                while (sdr.Read())
        //                {
        //                    DataRow row = dummy.NewRow();
        //                    row["FirstName"] = sdr["FirstName"].ToString();
        //                    row["LastName"] = sdr["LastName"].ToString();
        //                    row["MobileNo"] = sdr["MobileNo"].ToString();
        //                    row["Address"] = sdr["Address"].ToString();
        //                    row["Expertise"] = sdr["Expertise"].ToString();
        //                    dummy.Rows.Add(row);

        //                }
                    
                    
        //            }
        //            con.Close();
        //        }
        //    }

        //    return dummy;
        //}

        protected void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = BLL.SearchTrainer(SearchTextBox.Text);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}