using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public class OrderProxy
    {
        protected List<OrderCached> Cached = new List<OrderCached>();

        protected Order Order;

        public  OrderProxy()
        {
            Order = new Order();
        }

        public string Read(string orderNumber)
        {
            if(Cached.Count(s=>s.OrderNumber == orderNumber) > 0)
            {
                return Cached.Where(s => s.OrderNumber == orderNumber).Select(s => s.OrderContent).FirstOrDefault();
            }

            var result = Order.Read(orderNumber);

            Cached.Add(new OrderCached()
            {
                OrderNumber = orderNumber,
                OrderContent = result,
            });

            return result;
        }
    }

    public class OrderCached
    {
        public string OrderNumber { get; set; }

        public string OrderContent { get; set; }
    }
}
