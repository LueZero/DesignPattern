using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("蠅量模式測試");

            var phoneFactory = new PhoneFactory();

            var applePhone = phoneFactory.GetPhone("Apple");

            applePhone.Name = "Apple";
            applePhone.System = "IOS";
            applePhone.Reboot();

            var samsungPhon = phoneFactory.GetPhone("Apple");

            // 偷偷灌錄三星系統
            samsungPhon.Name = "Samsung";
            samsungPhon.System = "Android Os";
            samsungPhon.Reboot();
        }
    }
}
