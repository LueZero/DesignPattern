using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public interface IProduction
    {
        public IProduction Set();

        public IProduction Make();

        public string Check();
    }
}
