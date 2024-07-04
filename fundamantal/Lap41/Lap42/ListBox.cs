using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap42
{
    public class ListBox : window 
    {
        public string ListBoxContents { get; set; }

        public ListBox( int top, int left , string contents) : base(top, left)
        {
            ListBoxContents = contents;
        }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine($"Writing string to listbox: {ListBoxContents}");

        }

    }
}
