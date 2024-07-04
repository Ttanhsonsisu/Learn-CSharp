using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX
{
    public abstract class ADongVat
    {
        private string ID {  get; set; }
        private string Name { get; set; }
        private int Weight { get; set; }

        protected ADongVat(string iD, string name, int weight)
        {
            ID = iD;
            Name = name;
            Weight = weight;
        }
    }
}
