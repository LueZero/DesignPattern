using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Apple : PhoneAbstract
    {
        public override void Print()
        {
            Console.WriteLine("蘋果公司確認可加工");
        }
    }
}
