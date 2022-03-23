using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class SamsungFactory : ModelFactory
    {
        public override ProductInterface CreateModel()
        {
            return new SamsungPhone();
        }
    }
}
