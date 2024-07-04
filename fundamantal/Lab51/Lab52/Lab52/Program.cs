using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson staff = new Staff();

            object data = "it tn";

            staff.Insert(data);
            staff.Delete(data);
            staff.UPdate(data);
            staff.Display(data);

            IPerson stu = new Student()
            {
                Id = "10",
                Name = "it tn",
                Age = 20
            };
            stu.Display(stu);

            Console.ReadKey();
        }
    }
}
