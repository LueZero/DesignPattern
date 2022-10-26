using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Chain_Of_Responsibility
{
    public class CustomerDepartment : Approver
    {
        public CustomerDepartment(string name) : base(name) { }

        public override void RefundRequest(Refund request)
        {
            if (request.Day < 8)
            {
                Console.WriteLine("客服部 {0} 審批 {1} 請假", this.Name, request.OrderNumber);
            }
            else
            {
                NextApprover.RefundRequest(requeset);
            }
        }
    }
}
