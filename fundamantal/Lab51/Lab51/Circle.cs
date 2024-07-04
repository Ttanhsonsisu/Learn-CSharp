using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab51
{
    public class Circle : AShape
    {
        public void InputData ()
        {
            Console.WriteLine("nhap ban kinh");
            ratius = int.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return 3.14F * ratius * ratius;
        }

        public override float Circumference()
        {
            return 2 * 3.14F * ratius;
       }
    }
}
