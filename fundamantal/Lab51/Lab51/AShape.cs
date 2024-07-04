using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab51
{
     public abstract class AShape
    {
        protected float ratius;
        protected float length;
        protected float width;

        public abstract float Area();
        public abstract float Circumference();
    }
}
