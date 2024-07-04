using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact ct1 = new Contact();

            ct1.ID = 6;
            ct1.FirtName = "test first name";
            ct1.LastName = "test last name";
            ct1.Address = "address";
            ct1.Phone = "phone";
            ct1.Email = "email";

            Contact ct2 = new Contact(5, "first2" , "name2" , "address2", "Phone number 2", "test.com");

            ct1.DisPlay();
            ct2.DisPlay();

            Console.ReadLine();

        }
    }
}
