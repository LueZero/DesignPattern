using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Chain_Of_Responsibility
{
    public class Refund
    {
        public string OrderNumber { get; set; }

        public int Total { get; set; }

        public int Day { get; set; }

        public Refund(string orderNumber, int total, int day)
        {
            OrderNumber = orderNumber;
            Total = total;
            Day = day;
        }
    }
}
