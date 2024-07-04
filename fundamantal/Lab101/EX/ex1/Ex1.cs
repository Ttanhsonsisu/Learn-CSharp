using EX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnCo
{
    public class Bo : ADongVat
    {
        public Bo(string iD, string name, int weight) : base(iD, name, weight)
        {
        }

    }

    public class Trau : ADongVat
    {
        public Trau(string iD, string name, int weight) : base(iD, name, weight)
        {
        }
    }

    public class  De : ADongVat
    {
        public De(string iD, string name, int weight) : base(iD, name, weight) { }

    }
}
