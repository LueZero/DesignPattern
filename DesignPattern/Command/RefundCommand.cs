using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public class RefundCommand : Command
    {
        protected Order Order;

        public RefundCommand(Order order)
        {
            Order = order;
        }

        public void Execute()
        {
            Order.Refund();
        }
    }
}
