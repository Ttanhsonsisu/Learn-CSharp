using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Diagnostics;
namespace TestADO2
{

    public class TestConnect
    {

        public string ConfigConection { get; set; }

        private DbConnection conn;
        public TestConnect(string configConection)
        {
            ConfigConection = configConection;
            init();
            
        }

        private void init()
        {

            string sqlconnect = ConfigConection;

            DbConnection connection = new SqlConnection(sqlconnect);

            connection.StateChange += (object sender, StateChangeEventArgs e) =>
            {
                Console.WriteLine($"Kết nối thay đổi: {e.CurrentState}, trạng thái trước: " + $"{e.OriginalState}");
            };

            connection.Open();


            using (DbCommand cmd = new SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "select * from DMSV";

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["HoSV"]}");
                }
            }

           



            connection.Close();
        }
     }
}
