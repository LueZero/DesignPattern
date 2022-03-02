using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class Adapter
    {
        private readonly Mac _mac;

        public Adapter(Mac mac)
        {
            _mac = mac;
        }

        public string GetVersion()
        {
            return _mac.GetMacVersion();
        }
    }
}
