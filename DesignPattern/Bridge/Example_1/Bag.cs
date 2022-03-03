using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.Example_1
{
    public abstract class Bag
    {
        protected ColorInterface color;

        public void setColor(ColorInterface color)
        {
            this.color = color;
        }

        public abstract string GetName();
    }
}
