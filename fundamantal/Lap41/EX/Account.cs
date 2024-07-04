using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EX
{
    public class Account
    {
        protected string name;

        protected int balance;
        public Account(string name, int firstMoney)
        {
            this.name = name;
            balance = firstMoney;
        }

        public virtual void Deposite(int money)
        {
            if (money < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(money));
            }
            else {
                balance += money;
            }
            
        }

        public virtual void WithDraw(int money)
        {
            if (money < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(money));
                
            }
            else
            {
                balance -= money;
            }
        }

        public virtual int GetBalance() { return balance; }

    }
}
