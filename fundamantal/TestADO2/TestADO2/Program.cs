using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Net.Http.Headers;
using System.Data;
namespace TestADO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqlStringbuilder = new SqlConnectionStringBuilder();
            sqlStringbuilder["Data Source"] = "TTANH";
            sqlStringbuilder["Database"] = "QLDiemSV_67IT125";
            sqlStringbuilder["User ID"] = "sa";
            sqlStringbuilder["Password"] = "1234";



            //string sqltest = "Data Source = TTANH; Database = QLDiemSV_67IT125; User ID = sa; Password = 1234";
            
            string sqltest = sqlStringbuilder.ToString();
            //DbConnection dbConnection = new SqlConnection();
            SqlConnection dbConnection = new SqlConnection();
            dbConnection.ConnectionString = sqltest;
            dbConnection.Open();

            DbCommand cmd = new SqlCommand();

            cmd.Connection = dbConnection;
            cmd.CommandText = "select * from DMSV";

            var read = cmd.ExecuteReader();

            while (read.Read())  
            {
                Console.WriteLine($"{read["HoSV"]}");
            }
            read.Close();
            // dataset
            ADOPart3.EXADOPart3();
            //var test = new TestConnect(sqltest);


            //data Adapter

            var adapter = new SqlDataAdapter();

            adapter.TableMappings.Add("Table", "DMSV");

            //select Command 
            adapter.SelectCommand = new SqlCommand("select MaSV, HoSV from DMSV", dbConnection);

            // insert command 
            /*
            adapter.InsertCommand = new SqlCommand("insert into DMSV(MaSV, HoSV) values (@MaSV, @HoSV)", dbConnection);

            adapter.InsertCommand.Parameters.Add("@MaSV", SqlDbType.Char, 3, "MaSV");
            adapter.InsertCommand.Parameters.Add("@HoSV", SqlDbType.NVarChar, 10, "HoSV");
            */

            // Delete command
            /*
            adapter.DeleteCommand = new SqlCommand("Delete from DMSV where MaSv = @MaSV", dbConnection);
            var p1 = adapter.DeleteCommand.Parameters.Add(new SqlParameter("@MaSV", SqlDbType.Char,3));
            p1.SourceColumn = "MaSV";
            p1.SourceVersion = DataRowVersion.Original;
            */

            // update command

            adapter.UpdateCommand = new SqlCommand("Update DMSV set HoSV = @HoSV where MaSV = @MaSV", dbConnection);
            var p2 = adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MaSV", SqlDbType.Char, 3));
            p2.SourceColumn = "MaSV";
            p2.SourceVersion = DataRowVersion.Original;
            adapter.UpdateCommand.Parameters.Add("@HoSV", SqlDbType.NVarChar, 10, "HoSV");



            var dataSetsss = new DataSet();

            adapter.Fill(dataSetsss);

            DataTable table = dataSetsss.Tables["DMSV"];

            foreach (DataRow rows in table.Rows)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    Console.WriteLine($"{rows[i]}");
                }
            }

            // inser command
            /*
            var row = table.Rows.Add();

            row["MaSV"] = "001";
            row["HoSV"] = "Tran";
            */

            // delete 
            /*
            var rowDel = table.Rows[0];
            rowDel.Delete();
            */

            //update 
            /*
            var rowUp = table.Rows[0];
            rowUp["HoSV"] = "Tran thi";
            */
            adapter.Update(dataSetsss);
            dbConnection.Close();
            Console.ReadKey();
        }
    }
}
