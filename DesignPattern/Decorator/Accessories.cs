using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Accessories : Decorator
    {
        public Accessories(PhoneAbstract phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();

            // 新增新的行為
            AddAccessories();
        }

        public void AddAccessories()
        {
            Console.WriteLine("現在蘋果手機有漂亮的掛件了");
        }
    }
}
