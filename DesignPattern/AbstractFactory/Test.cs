using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    class Test
    {
        public void test()
        {
            Console.WriteLine("抽象工廠測試");

            GUIFactoryInterface win = new WinFactory();

            var system = new System(win);

            system.Paint();
        }
    }
}
