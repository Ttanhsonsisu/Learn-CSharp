using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap41
{
    public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int Age { get; set; }
        
        public void display()
        {
            Console.WriteLine($"id {this.Id}");
            Console.WriteLine($"name {this.Name}");
            Console.WriteLine($"age {this.Age}");
        } 

    }
}
