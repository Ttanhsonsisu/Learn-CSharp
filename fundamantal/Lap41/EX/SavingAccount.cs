using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX
{
    public class SavingAccount : Account
    {
        public double Rate {  get; set; }

        public SavingAccount(string name , int initialize, double rate) : base(name, initialize)
        {
            Rate = rate;
        }

        public double GetInterest()
        {
            return (double)balance * Rate; 
        }



    }
}
