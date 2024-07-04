using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab51
{
    public class Rectangle : AShape
    {
        
        public override float Area()
        {
            return length * width; 
        }

        public override float Circumference()
        {
            return 2 * (length + width);
        }

        public void InputData()
        {
            Console.WriteLine("nhap chieu dai:");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap chieu rong:");
            width = int.Parse(Console.ReadLine());
        }
    }
}
