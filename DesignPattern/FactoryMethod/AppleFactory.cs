using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class AppleFactory : ProductFactory
    {
        public override ProductInterface CreateModel()
        {
            return new ApplePhone();
        }
    }
}
