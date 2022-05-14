using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    class Member
    {
        public Order Order;

        private string _orderNumber;

        private bool _orderStatus;

        public Member(Order order)
        {
            Order = order;
        }

        public void WriteOrderNumber(string orderNumber)
        {
            _orderNumber = orderNumber;
        }

        public void WriteStatus(bool orderStatus)
        {
            _orderStatus = orderStatus;
        }

        public bool GetNotSavedOrderStatus()
        {
            return _orderStatus;
        }

        public void UpdateStatus()
        {
            var status = new Status(_orderNumber, _orderStatus);

            _orderNumber = null;

            _orderStatus = false;

            Order.Update(status);
        }
    }
}
