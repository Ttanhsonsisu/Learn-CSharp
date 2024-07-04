using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap42
{
    public class Button : window
    {
        public Button(int top, int left) : base(top, left)
        { 
        
        }

        public override void DrawWindow()
        {
            Console.WriteLine($"Draw a button at {top} {left}");

        }
    }
}
