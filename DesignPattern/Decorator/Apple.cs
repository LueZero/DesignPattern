using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Apple : PhoneAbstract
    {
        /// <summary>
        /// 重寫基類方法
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("開始執行具體的物件——蘋果手機");
        }
    }
}
