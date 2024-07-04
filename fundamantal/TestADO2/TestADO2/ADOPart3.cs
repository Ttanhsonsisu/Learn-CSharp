using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestADO2
{
    public static class ADOPart3
    {
        public static  void EXADOPart3()
        {
            var dataTable = new DataTable("Table test");

            var dataSet = new DataSet();

            dataSet.Tables.Add(dataTable);

            dataTable.Columns.Add("id");
            dataTable.Columns.Add("name");
            dataTable.Columns.Add("email");

            dataTable.Rows.Add(1, "name1", "email1");
            dataTable.Rows.Add(2, "name2", "email2");
            dataTable.Rows.Add(1, "name2", "email3");

            // access to table

            foreach(DataColumn d in dataTable.Columns)
            {
                Console.WriteLine(d.ColumnName);
            }

            foreach (DataRow dr in dataTable.Rows)
            {
                Console.WriteLine($"{dr[0], 20}");// read after field

                Console.WriteLine($"{dr["name"]}"); // read after key name
            }





        }
    }
}
