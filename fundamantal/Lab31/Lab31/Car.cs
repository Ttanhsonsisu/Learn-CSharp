using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab31
{
    internal class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
        public int year { get; set; }

        public void Start()
        {
            Console.WriteLine(Model + "khoi dong");
        }

        public void Stop()
        {
            Console.WriteLine(Model + "dung");
        }

    }
}
