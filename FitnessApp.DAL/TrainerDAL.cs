using FitnessApp.BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.DAL
{
    public class TrainerDAL
    {
        string _connectionString = "data source=DESKTOP-EU5NRVT\\SQLEXPRESS; database=FitnessDb; integrated security=true;";

        public Trainer AddTrainer(Trainer objTrainerBo)
        {
            return objTrainerBo;

        }
        public Trainer GetTrainer(int Trainerid)
        {
            Trainer co = new Trainer();
            return co;

        }
        public Trainer TrainerUpdate(Trainer objTrainertBo)
        {
            Trainer co = new Trainer();
            return co;

        }
        public List<Trainer> ShowTrainers()
        {
            return new List<Trainer>();
        }
        public DataTable GetTrainers(Trainer objTrainerBo)
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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_trainer where UserName = '"+objTrainerBo.Username+"'", con))
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
        public int DeleteTrainer(Trainer objTrainerBo)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "Delete from tbl_trainer where UserName=@UserName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", objTrainerBo.Username);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }

            }


            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "Delete from tbl_login where UserName=@UserName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", objTrainerBo.Username);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
                count = 1;
                return count;
            }
        }
        public int TrainerEdit(Trainer objTrainerBo)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "Update tbl_trainer SET FirstName=@FirstName,LastName=@LastName,MobileNo=@MobileNo,Address=@Address,Expertise=@Expertise where UserName=@UserName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", objTrainerBo.FirstName);
                    command.Parameters.AddWithValue("@LastName", objTrainerBo.LastName);
                    command.Parameters.AddWithValue("@MobileNo", objTrainerBo.MobileNo);
                    command.Parameters.AddWithValue("@Address", objTrainerBo.Address);
                    command.Parameters.AddWithValue("@Expertise", objTrainerBo.Expertise);
                    command.Parameters.AddWithValue("@UserName", objTrainerBo.Username);


                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }

                count = 1;
                return count;

            }
        }
        public int TrainerLogin(Trainer objTrainerBo)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "select count(*) from tbl_login where UserName='" + objTrainerBo.Username + "' and Password='" + objTrainerBo.Password + "'and RoleID = 2";


                using (var cmd = new SqlCommand(query, con))
                {
                    int rowsAmount = (int)cmd.ExecuteScalar(); // get the value of the count
                    if (rowsAmount > 0)
                    {
                        return rowsAmount;
                    }

                }
            }
            return 0;
        }
        public int TrainerSignUp(Trainer objTrainerBo)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                String query = "INSERT INTO tbl_trainer (FirstName,LastName,MobileNo,Address,Expertise,UserName,Password) VALUES (@FirstName,@LastName,@MobileNo,@Address,@Expertise,@UserName,@Password)";
                

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", objTrainerBo.FirstName);
                    command.Parameters.AddWithValue("@LastName", objTrainerBo.LastName);
                    command.Parameters.AddWithValue("@MobileNo", objTrainerBo.MobileNo);
                    command.Parameters.AddWithValue("@Address", objTrainerBo.Address);
                    command.Parameters.AddWithValue("@Expertise", objTrainerBo.Expertise);
                    command.Parameters.AddWithValue("@UserName", objTrainerBo.Username);
                    command.Parameters.AddWithValue("@Password", objTrainerBo.Password);

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
                    command.Parameters.AddWithValue("@UserName", objTrainerBo.Username);
                    command.Parameters.AddWithValue("@Password", objTrainerBo.Password);
                    command.Parameters.AddWithValue("@RoleID", 2);

                    connection.Open();
                    int result = command.ExecuteNonQuery()
                        ;
                    connection.Close();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }

                count = 1;
                return count;
            }
        }
    }
}
