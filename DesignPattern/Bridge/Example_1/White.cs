using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge.Example_1
{
    public class White : ColorInterface
    {
        public string getColor()
        {
            return "白色";
        }
    }
}
