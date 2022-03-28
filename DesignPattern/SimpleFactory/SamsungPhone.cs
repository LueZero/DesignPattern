using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class SamsungPhone : ProductInterface
    {
        public void Wholesale()
        {
            Console.WriteLine("批發三星手機");
        }
    }
}
