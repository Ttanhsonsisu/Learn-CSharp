using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab51
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.InputData();
            Console.WriteLine("dien tich hinh cn:{0:N}" , rectangle.Area());
            Console.WriteLine("cv hinh cn:{0:N}", rectangle.Circumference());

            Circle circle = new Circle();
            circle.InputData();
            Console.WriteLine("dien tich hinh tron:{0:N}", circle.Area());
            Console.WriteLine("dien tich hinh tron:{0:N}", circle.Circumference());

            Console.ReadKey();
        }
    }
}
