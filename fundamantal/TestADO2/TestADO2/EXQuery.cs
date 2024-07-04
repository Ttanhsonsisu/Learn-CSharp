using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestADO2
{
    internal class EXQuery
    {
        public void ConnectToDB()
        {
            var stringSqlBuilder = new SqlConnectionStringBuilder();

            var sqlStringbuilder = new SqlConnectionStringBuilder();
            sqlStringbuilder["Data Source"] = "TTANH";
            sqlStringbuilder["Database"] = "QLDiemSV_67IT125";
            sqlStringbuilder["User ID"] = "sa";
            sqlStringbuilder["Password"] = "1234";

            string sqlConnect = sqlStringbuilder.ToString();

            DbConnection conn = new SqlConnection(sqlConnect);

            conn.Open();

             DbCommand command = new SqlCommand() ;

            command.Connection = conn;

            command.CommandText = "select MaSV , Hosv , tenSv from  DMSV d where d.HocBong > @moneyOfHB"; // use @ for khai bao bien

            //var moneyOfHB = new SqlParameter("@moneyOfHB", 150000); // set value
            //command.Parameters.Add(moneyOfHV); // them value;

            
            // thuc thi cau lenh sql
            //command.ExecuteNonQuery();
            //command.ExecuteReader(); - dung khi ket qua tra ve co nhieu dong

            //command.ExecuteScalar(); - tra ve gia tri dong 1 cot 1 (ke ca cau sql co tra ve nhieu gia tri

            var sqlEx = command.ExecuteReader();

            var dbTable = new DataTable();
            dbTable.Load(sqlEx);
            // in DataTable has properties : column , row 



        }
      


    }
}
