using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    public interface RoadRunRole
    {
        public string Name { get; set; }

        public void GetJoggingShoes(RoadRunType roadRunType);

        public void GetSupplies(RoadRunType roadRunType);
    }
}
