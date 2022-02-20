using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public interface PhonePrototypeInterface 
    {
        public string Manufacturer { get; set; }

        public string Version { get; set; }

        public string System { get; set; }

        public void GetManufacturer();

        public abstract PhonePrototypeInterface Clone();
    }
}
