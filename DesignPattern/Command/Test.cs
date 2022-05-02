using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    class Test
    {
        public void Tests()
        {
            Console.WriteLine("命令模式測試");

            var a = new ACustomerSservice();
            var b = new BCustomerSservice();

            var checkoutCommand = new CheckoutCommand(a);
            var refundCommand = new RefundCommand(b);

            checkoutCommand.Execute();
            refundCommand.Execute();
        }
    }
}
