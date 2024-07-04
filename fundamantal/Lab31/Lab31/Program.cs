using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Make1";
            myCar.Model = "model1";
            myCar.Color = "color1";
            myCar.year = 1;
            Console.WriteLine("thong tin chi tiet");
            Console.WriteLine("make: " + myCar.Make);
            Console.WriteLine("model" + myCar.Model);
            Console.WriteLine("color" + myCar.Color);
            Console.WriteLine("year release: " + myCar.year);

            myCar.Start();
            myCar.Stop();
    
        }
    }
}
