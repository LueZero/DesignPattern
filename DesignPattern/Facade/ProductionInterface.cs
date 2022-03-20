using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public interface ProductionInterface
    {
        public ProductionInterface Set();

        public ProductionInterface Make();

        public ProductionInterface Check();
    }
}
