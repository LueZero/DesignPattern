using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    class Apple : ProductionInterface
    {
        public ProductionInterface Check()
        {
            return this;
        }

        public ProductionInterface Manufacture()
        {
            return this;
        }

        public ProductionInterface Set()
        {
            return this;
        }
    }
}
