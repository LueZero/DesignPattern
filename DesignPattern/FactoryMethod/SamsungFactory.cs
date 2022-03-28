using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class SamsungFactory : ProductFactory
    {
        public override ProductInterface CreateProduct()
        {
            return new SamsungPhone();
        }
    }
}
