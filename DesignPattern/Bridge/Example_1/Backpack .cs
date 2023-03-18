using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.Example_1
{
    public class Backpack : Bag
    {
        public override string GetName()
        {
            return Color.getColor() + "Backpack";
        }
    }
}
