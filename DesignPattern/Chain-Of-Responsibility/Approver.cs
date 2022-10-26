using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Chain_Of_Responsibility
{
    public abstract class Approver
    {
        public Approver NextApprover { get; set; }

        public string Name { get; set; }

        public Approver(string name)
        {
            this.Name = name;
        }

        public abstract void RefundRequest(Refund request);
    }
}
