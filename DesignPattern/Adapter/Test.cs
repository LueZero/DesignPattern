using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("配接器模式測試");

            var adapter = new Adapter(new Mac());

            Console.WriteLine(adapter.GetVersion());
        }
    }
}
