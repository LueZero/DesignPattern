using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Sticker : Decorator
    {
        public Sticker(PhoneAbstract phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();

            // 新增新的行為
            AddSticker();
        }

        /// <summary>
        /// 新的行為方法
        /// </summary>
        public void AddSticker()
        {
            Console.WriteLine("現在蘋果手機有貼膜了");
        }
    }
}
