using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("備忘錄模式測試");

            var order = new Order();
            var member = new Member(order);

            member.WriteOrderNumber("test001");
            member.WriteStatus(true);
            Console.WriteLine(member.GetNotSavedOrderStatus()); // true

            member.UpdateStatus();
            Console.WriteLine(member.GetNotSavedOrderStatus()); // null

            member.WriteOrderNumber("test002");
            member.WriteStatus(true);
            member.UpdateStatus();
        }
    }
}
