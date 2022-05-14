using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    class Status
    {
        public string _orderNumber { get; set; }

        private bool _orderStatus { get; set; }

        public Status(string orderNumber, bool orderStatus)
        {
            _orderNumber = orderNumber;
            _orderStatus = orderStatus;
        }

        public bool GetStatus()
        {
            return _orderStatus;
        }
    }
}
