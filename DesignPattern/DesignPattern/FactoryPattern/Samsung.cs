using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    public class Samsung : ProductInterface
    {
        public string GetBrand()
        {
            return "Samsung";
        }
    }
}
