using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            window win = new window(1, 2);
            ListBox lb = new ListBox(3,4 , "listboxtest1");
            Button b = new Button(5, 6);

            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();
            window[] winArray = new window[3];

            winArray[0] = new window(1,2);
            winArray[1] = new ListBox(3,4, "lis box in array");
            winArray[2] = new window(5,6);
            
            for(int i = 0; i < winArray.GetLength(0); i++)
            {
                winArray[i].DrawWindow();
            }

            Console.ReadLine();
        }
    }
}
