using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap42
{
    public class window
    {
        protected int top;
        protected int left;

        public window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine($"Window: drawing windown at {this.top} {this.left}");


        } 
    }
}
