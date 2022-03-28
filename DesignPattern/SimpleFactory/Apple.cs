using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class Apple : ProductInterface
    {
        public void Wholesale()
        {
            Console.WriteLine("批發蘋果手機");
        }
    }
}
