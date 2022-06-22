using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    class Apple : ProductionInterface
    {
        public ProductionInterface Set()
        {
            return this;
        }

        public ProductionInterface Make()
        {
            return this;
        }

        public string Check()
        {
            return "OK";
        }
    }
}
