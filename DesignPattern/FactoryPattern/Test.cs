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

            PhoneFactoryInterface AppleFactory = new AppleFactory();
            ProductInterface Apple = AppleFactory.GetProdcut();
            Console.WriteLine(Apple.GetBrand());

            PhoneFactoryInterface SamsungFactory = new SamsungFactory();
            ProductInterface Samsung = SamsungFactory.GetProdcut();
            Console.WriteLine(Samsung.GetBrand());
        }
    }
}
