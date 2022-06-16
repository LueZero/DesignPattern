﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor
{
    class Junior : RoadRunRole
    {
        public string Name { get => _name; set { _name = value; } }

        private string _name;

        public Junior()
        {
            _name = "Junior";
        }

        public void GetJoggingShoes(RoadRunType roadRunType)
        {
            roadRunType.GetJoggingShoes(this);
        }

        public void GetSupplies(RoadRunType roadRunType)
        {
            roadRunType.GetSupplies(this);
        }
    }
}
