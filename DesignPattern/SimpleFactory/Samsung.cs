using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class Samsung : PhoneInterface
    {
        public void Photo()
        {
            Console.WriteLine("三星照相");
        }

        public void Music()
        {
            Console.WriteLine("三星音樂");
        }
    }
}
