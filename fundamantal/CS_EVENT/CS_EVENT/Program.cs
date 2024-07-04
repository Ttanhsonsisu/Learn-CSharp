using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EVENT
{
    /*
      + publisher -> class phat event
      + subsriber -> class nhan event
        
        + use delegate for deploy
     
     */

    // publisher
    class UserInput
    {
    
        public void Input() 
        {
            string s = Console.ReadLine();
            int i = Int32.Parse(s);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
