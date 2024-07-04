using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab32
{
    public class Contact
    {
        public int ID {  get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Contact()
        {
        }

        public Contact(int iD, string firtName, string lastName)
        {
            ID = iD;
            FirtName = firtName;
            LastName = lastName;
        }

        public Contact(int iD, string firtName, string lastName, string address, string phone, string email) : this(iD, firtName, lastName)
        {
            Address = address;
            Phone = phone;
            Email = email;
        }

        public void DisPlay()
        {
            Console.WriteLine("ma so : " + ID);
            Console.WriteLine($"ho va ten: {this.FirtName} {this.LastName}");
            Console.WriteLine($"di chi {this.Address}");
            Console.WriteLine("dien thoai " + this.Phone);
            Console.WriteLine("email" + this.Email);

        }


    }
}
