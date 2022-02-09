using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPattern.SimpleFactory
{
    public class ApplePhone : PhoneInterface
    {
        public void Photo()
        {
            Console.WriteLine("照相");
        }

        public void Music()
        {
            Console.WriteLine("音樂");
        }
    }
}
