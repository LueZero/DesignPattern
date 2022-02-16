using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    public class Test
    {
        public void test()
        {
            Console.WriteLine("工廠模式測試");

            PhoneFactoryInterface appleFactory = new AppleFactory();
            ProductInterface apple = appleFactory.GetProdcut();
            Console.WriteLine(apple.GetBrand());

            PhoneFactoryInterface samsungFactory = new SamsungFactory();
            ProductInterface samsung = samsungFactory.GetProdcut();
            Console.WriteLine(samsung.GetBrand());
        }
    }
}
