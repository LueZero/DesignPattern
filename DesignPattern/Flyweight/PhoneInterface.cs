using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Flyweight
{
    public interface PhoneInterface
    {
        public string Name { get; set; }

        public string System { get; set; }

        public void Reboot();
    }
}
