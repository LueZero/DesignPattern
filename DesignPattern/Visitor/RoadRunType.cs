using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    public interface RoadRunType
    {
        public void GetJoggingShoes(RoadRunRole roadRunRole);

        public void GetSupplies(RoadRunRole roadRunRole);
    }
}
