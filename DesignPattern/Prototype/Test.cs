using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public class Test
    {
        public void Tests()
        {
            Console.WriteLine("原型模式測試");

            var apple = new Apple();
            apple.Manufacturer = "美國科技製造商";

            PhonePrototypeInterface apple2 = apple.Clone();
            apple2.Manufacturer = "台灣科技製造商";

            apple.GetManufacturer();
            apple2.GetManufacturer();
        }
    }
}
