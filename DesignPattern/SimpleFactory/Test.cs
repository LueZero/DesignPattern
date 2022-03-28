using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class Test
    {
        public void Tests()
        {
            Console.WriteLine("簡單工廠模式測試");

            ProductInterface apple = PhoneFactory.CreatePhone("Apple");
            apple.Wholesale();

            ProductInterface samsung = PhoneFactory.CreatePhone("Samsung");
            samsung.Wholesale();
        }
    }
}
