using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX
{
    public class CheckAccount : Account
    {
        public int FeeTranfer {  get; set; }

        public CheckAccount(string name, int initialize, int feeTransfer) : base(name, initialize) {
            FeeTranfer = feeTransfer; 
        }

        public override void Deposite(int money)
        {
            base.Deposite((money -FeeTranfer));
        }

        public override void WithDraw(int money)
        {
            if (balance < FeeTranfer)
            {
                throw new ArgumentException();
            }
            base.WithDraw(money - FeeTranfer);
        }

        public override int GetBalance()
        {
            return base.GetBalance();
        }
    }
}
