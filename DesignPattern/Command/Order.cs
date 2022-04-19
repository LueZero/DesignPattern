using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public abstract class Order
    {
        public string Checkout()
        {
            return "結帳";
        }

        public string Refund()
        {
            return "退款";
        }
    }
}
