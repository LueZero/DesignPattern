using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public abstract class State
    {
        const string License = "Undefined";

        const string OrderNumber = "Undefined";

        public string GetLicense()
        {
            return OrderNumber;
        }

        public abstract void Register();

        public abstract void Update();
    }
}
