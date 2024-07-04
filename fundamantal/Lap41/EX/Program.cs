using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckAccount test = new CheckAccount("test name", 1000000,  1500);

            Console.WriteLine("gui: ");
            Console.WriteLine($"tien truoc: {test.GetBalance()} tien sau khi rut:");
            test.Deposite(100000);
            Console.WriteLine($"tien sau gui" + test.GetBalance());

            
            Console.WriteLine("rut");
            test.WithDraw(10000);
            Console.WriteLine("tien sau rut" + test.GetBalance());

            Console.ReadLine();
        }
    }
}
