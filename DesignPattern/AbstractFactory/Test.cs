using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("抽象工廠模式測試");

            GUIFactoryInterface win = new WinFactory();

            var system = new System(win);

            system.Paint();
        }
    }
}
