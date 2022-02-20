using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public class Apple : PhonePrototypeInterface
    {
        public string Manufacturer { get; set; }
        public string Version { get; set; }
        public string System { get; set; }

        public PhonePrototypeInterface Clone()
        {
            return (Apple) MemberwiseClone();
        }
        
        public void GetManufacturer()
        {
            Console.WriteLine(this.Manufacturer);
        }
    }
}
