using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("觀察者模式測試");

            var message = new Message();

            message.Run();
        }
    }
}
