using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    public class SamsungFactory : PhoneFactoryInterface
    {
        public ProductInterface GetProdcut()
        {
            Console.WriteLine("三星手機");
            return new Samsung();
        }
    }
}
