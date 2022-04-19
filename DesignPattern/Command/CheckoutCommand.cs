using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public class CheckoutCommand : Command
    {
        protected Order Order;

        public CheckoutCommand(Order order)
        {
            Order = order;
        }

        public void Execute()
        {
            Order.Checkout();
        }
    }
}
