﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Chain_Of_Responsibility
{
    public class SalesDepartment : Approver
    {
        public SalesDepartment(string name) : base(name) { }

        public override void RefundRequest(Refund requeset)
        {
            if (requeset.Day < 15)
            {
                Console.WriteLine("銷售部 {0} 審批 {1} 請假", this.Name, requeset.OrderNumber);
            }
            else
            {
                NextApprover.RefundRequest(requeset);
            }
        }
    }
}
