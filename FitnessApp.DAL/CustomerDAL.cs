using FitnessApp.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FitnessApp.DAL
{
    public class CustomerDAL
    {
        string _connectionString = "data source=DESKTOP-EU5NRVT\\SQLEXPRESS; database=FitnessDb; integrated security=true;";

        public Customer AddCustomer(Customer objCustomerBo)
        {
            return objCustomerBo;

        }
        public Customer GetCustomer(int customerid)
        {
            Customer co = new Customer();
            return co;

        }
        public Customer CustomerUpdate(Customer objCustomerBo)
        {
            Customer co = new Customer();
            return co;

        }
        public List<Customer> ShowCustomers()
        {
            return new List<Customer>();
        }

        public int CustomerLogin(Customer objCustomerBo)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "select count(*) from tbl_login where UserName='" + objCustomerBo.Username + "' and Password='" + objCustomerBo.Password + "'and RoleID = 3";


                using (var cmd = new SqlCommand(query, con))
                {
                    int rowsAmount = (int)cmd.ExecuteScalar(); // get the value of the count
                    if (rowsAmount > 0)
                    {
                        return rowsAmount;
                    }

                }
                return 0;
            }
        }
        public bool CustomerSignup(Customer objCustomerBo)
        {
            bool isInserted = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                String query = "INSERT INTO tbl_customer (FirstName,LastName,MobileNo,Address,UserName,Password) VALUES (@FirstName,@LastName,@MobileNo,@Address,@UserName,@Password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", objCustomerBo.FirstName);
                    command.Parameters.AddWithValue("@LastName", objCustomerBo.LastName);
                    command.Parameters.AddWithValue("@MobileNo", objCustomerBo.MobileNo);
                    command.Parameters.AddWithValue("@Address", objCustomerBo.Address);
                    command.Parameters.AddWithValue("@UserName", objCustomerBo.Username);
                    command.Parameters.AddWithValue("@Password", objCustomerBo.Password);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }

                String query1 = "INSERT INTO tbl_login (UserName,Password,RoleID) VALUES (@UserName,@Password,@RoleID)";

                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@UserName", objCustomerBo.Username);
                    command.Parameters.AddWithValue("@Password", objCustomerBo.Password);
                    command.Parameters.AddWithValue("@RoleID", 3);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }

            }
            isInserted = true;
            return isInserted;



        }
        public DataTable GetCustomers(Customer objCustomerBo)
        {
            DataTable dummy = new DataTable();
            dummy.Columns.Add("FirstName");
            dummy.Columns.Add("LastName");
            dummy.Columns.Add("MobileNo");
            dummy.Columns.Add("Address");
            dummy.Columns.Add("Expertise");

            List<string> customers = new List<string>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_trainer", con))
                {
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            DataRow row = dummy.NewRow();
                            row["FirstName"] = sdr["FirstName"].ToString();
                            row["LastName"] = sdr["LastName"].ToString();
                            row["MobileNo"] = sdr["MobileNo"].ToString();
                            row["Address"] = sdr["Address"].ToString();
                            row["Expertise"] = sdr["Expertise"].ToString();
                            dummy.Rows.Add(row);

                        }


                    }
                    con.Close();
                }
            }

            return dummy;
        }
        
        public DataTable SearchTrainers(string searchedtext)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select FirstName,LastName,MobileNo,Address,Expertise from tbl_trainer where Expertise like '" + searchedtext + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();

            return dt;
          
        }

    }
}
