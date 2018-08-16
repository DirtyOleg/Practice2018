using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ConnectToDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleNonQuery();
            SimpleQuery();
            //SimpleCRUD();

            Console.Read();
        }

        private static void SimpleCRUD()
        {
            string connString = GetConnectionString();
            string commandText = "select * from [dbo].[CAR] where [make]='BMW'";

            using (SqlDataAdapter adapter = new SqlDataAdapter(commandText, connString))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //breakpoint

                DataRowCollection rows = dt.Rows;
                foreach (DataRow row in rows)
                {
                    if (row["model"].ToString().Trim() == "i8")
                    {
                        row.Delete();
                    }
                    else if (row["model"].ToString().Trim() == "i3")
                    {
                        row["price"] = 1;
                    }
                }

                using (SqlCommandBuilder builder = new SqlCommandBuilder(adapter))
                {
                    adapter.Update(dt);
                }

                Console.WriteLine("Update done");
            }
        }

        private static void SimpleQuery()
        {
            string connString = GetConnectionString();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from [dbo].[CAR] where [make]=@make";
                    cmd.Parameters.AddWithValue("@make", "BMW");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["vin"] + " " + reader["model"]);
                        }
                    }
                }
            }

            Console.WriteLine("Select done");

        }

        static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        }

        static void SimpleNonQuery()
        {
            string connString = GetConnectionString();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdText = "insert into [dbo].[CAR]([make],[model],[year],[color],[price]) values('BMW','i8',2016,'White',18000);";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = cmdText;

                try
                {
                    conn.Open();

                    int affectLines = cmd.ExecuteNonQuery();
                    Console.WriteLine($"total affect {affectLines} lines");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
