using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap33
{
     static class DateTimeStatic
    {
        public static string name;
        static DateTimeStatic()
        {
            name = "Bay gio la";
        }

        public static void Show()
        {
            DateTime d = DateTime.Now;
            Console.WriteLine($"{name} :{d.Hour} : {d.Minute} : {d.Second} : {d.Day} : {d.Month} : {d.Year}");
        }

    }
}
