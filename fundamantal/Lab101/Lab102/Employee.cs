using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab102
{
    internal class Employee
    {
        private string name;
        private string address;
        private int age;
        public Employee(string name, string address, int age)
        {
            this.name = name;
            this.address = address;
            if (age < 18)
            {
                throw new ArgumentException("Tuoi khong hop le");

            } else
            {
                this.age = age;
            }
            
        }
        
    }
}
