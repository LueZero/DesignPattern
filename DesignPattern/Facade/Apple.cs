using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    class Apple : IProduction
    {
        public IProduction Set()
        {
            return this;
        }

        public IProduction Make()
        {
            return this;
        }

        public string Check()
        {
            return "OK";
        }
    }
}
