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

            ProductInterface applePhone = PhoneFactory.CreatePhone("Apple");
            applePhone.Wholesale();

            ProductInterface samsungPhone = PhoneFactory.CreatePhone("Samsung");
            samsungPhone.Wholesale();
        }
    }
}
