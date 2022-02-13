using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    public class AppleFactory : PhoneFactoryInterface
    {
        public ProductInterface GetProdcut()
        {
            Console.WriteLine("蘋果手機");
            return new Apple();
        }
    }
}
