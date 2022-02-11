using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    public class Apple : PhoneInterface
    {
        public void Photo()
        {
            Console.WriteLine("蘋果照相");
        }

        public void Music()
        {
            Console.WriteLine("蘋果音樂");
        }
    }
}
