using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public abstract class State
    {
        const string Licence = "Undefined";

        const string OorderNumber = "Undefined";

        public string GetLicense()
        {
            return OorderNumber;
        }

        public abstract void Register();

        public abstract void Update();
    }
}
